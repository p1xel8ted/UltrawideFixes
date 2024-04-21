Shader "Hidden/SpriteAssetUI"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
	}
	SubShader
	{
		Blend SrcAlpha OneMinusSrcAlpha

		Pass
		{
			Name "SpriteAssetEditor"
			
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma multi_compile _ IS_STATIC_PREVIEW

			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float4 vertex : SV_POSITION;
				float2 uv : TEXCOORD0;
			};

			Texture2D _MainTex;
			Texture2D _EmissiveTex;
			SamplerState point_clamp_sampler;
			float4 _TexelSize;
			float _FrameCount;
			float _Frame;
			float2 _Pivot;
			float2 _Size;
			float _Aspect;

			Texture2D _GradientMap;
			float _UseGradientMap;

			#define GRADIENT_MAP_WIDTH 256

			float3 LinearToGamma(float3 x)
			{
				return max(1.055 * pow(max(x, 0.0), 0.416666667) - 0.055, 0.0);
			}

			float3 SampleGradients(float3 color)
			{
				float3 key = (LinearToGamma(color) * (GRADIENT_MAP_WIDTH - 1.0) + 0.5) / GRADIENT_MAP_WIDTH;
				color = _GradientMap.SampleLevel(point_clamp_sampler, float2(key.r, 0), 0, 0).rgb;
				return color;
			}

			v2f vert (appdata v)
			{
				v2f o;

				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;
				o.uv.x = (o.uv.x - 0.5) / _Aspect + 0.5;

				return o;
			}

			float4 frag(v2f i) : SV_Target
			{
				float2 spriteUV = i.uv;
				spriteUV.x = (spriteUV.x + _Frame) / _FrameCount;

				float2 srcPixel = floor(spriteUV * _TexelSize.zw);
				float checkerboard = (srcPixel.x + srcPixel.y) % 2 == 0;

				float3 color = 0.2 + checkerboard * 0.02;

				float4 sprite = _MainTex.SampleLevel(point_clamp_sampler, spriteUV, 0);

				if (_UseGradientMap == 1.0)
				{
					sprite.rgb = SampleGradients(sprite.rgb);
				}

				float4 emissive = _EmissiveTex.SampleLevel(point_clamp_sampler, spriteUV, 0);
				if (any(abs(i.uv - 0.5) > 0.5))
				{
					sprite = 0.0;
					emissive = 0.0;
				}

#if IS_STATIC_PREVIEW
				sprite.a = max(sprite.a, emissive.a);
#endif

				color = lerp(color, sprite.rgb, sprite.a);
				color += emissive.rgb * emissive.a;

#if !IS_STATIC_PREVIEW
				color.rgb = LinearToGammaSpace(color.rgb);
#endif

				float2 pivotDist = abs(i.uv - _Pivot);
				if (pivotDist.x < 1.0 / _Size.x)
				{
					color = lerp(color, float3(1, 0, 0), 0.5);
				}
				if (pivotDist.y < 1.0 / _Size.y)
				{
					color = lerp(color, float3(0, 1, 0), 0.5);
				}
#if IS_STATIC_PREVIEW
				return float4(color, sprite.a);
#else
				return float4(color, 1.0);
#endif
			}
			ENDCG
		}

		Pass
		{
			Name "TransformAnimationEditor"
			
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			#include "UnityCG.cginc"
			#include "../../Shaders/SpriteObject.hlsl"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float4 vertex : SV_POSITION;
				float2 uv : TEXCOORD0;
			};

			v2f vert (appdata v)
			{
				v2f o;

				o.vertex = mul(UNITY_MATRIX_MVP, v.vertex);
				o.uv = v.uv;

				return o;
			}

			// https://www.shadertoy.com/view/XtBfzz
			float gridTextureGradBox(float2 p)
			{
				const float N = 50.0;
				float2 w = max(abs(ddx(p)), abs(ddy(p))) + 0.01;
				float2 a = p + 0.5*w;                        
				float2 b = p - 0.5*w;           
				float2 i = (floor(a)+min(frac(a)*N,1.0)-floor(b)-min(frac(b)*N,1.0))/(N*w);
				return (1.0-i.x)*(1.0-i.y);
			}

			// https://iquilezles.org/articles/intersectors/
			float3 triIntersect(float3 ro, float3 rd, float3 v0, float3 v1, float3 v2 )
			{
				float3 v1v0 = v1 - v0;
				float3 v2v0 = v2 - v0;
				float3 rov0 = ro - v0;
				float3 n = cross(v1v0, v2v0);
				float3 q = cross(rov0, rd);
				float d = 1.0/dot(rd, n);
				float u = d*dot(-q, v2v0);
				float v = d*dot( q, v1v0);
				float t = d*dot(-n, rov0);
				if (u<0.0 || v<0.0 || (u+v)>1.0) t = -1.0;
				return float3(t, u, v);
			}

			float3 quadIntersect(float3 ro, float3 rd, float4 v0, float4 v1, float4 v2, float4 v3)
			{
				float3 tri1 = triIntersect(ro, rd, v0, v3, v1);
				float3 tri2 = triIntersect(ro, rd, v2, v1, v3);
				float2 uv = 0;
				float dist = -1;
				if (tri1.x > 0)
				{
					dist = tri1.x;
					uv = tri1.yz;
				}
				if (tri2.x > 0)
				{
					dist = tri2.x;
					uv = 1-tri2.yz;
				}
				return float3(dist, uv);
			}

			float4 frag(v2f i) : SV_Target
			{
				float3 ro = float3(0, 1.1, -2);
				float3 rd = normalize(float3(i.uv.x - 0.5, i.uv.y - 0.8, 1.0));
				float rayLength = 1e10;
				float groundDist = ro.y / -rd.y;
				float3 groundPos = ro + rd * groundDist;
				float3 normal = 0;
				float3 color = 0.0;
				int type = 0;
				if (rd.y < 0)
				{
					color = gridTextureGradBox(groundPos.xz * 2) * 0.2 + 0.3;
					rayLength = groundDist;
					normal = float3(0, 1, 0);
					type = 1;
				}

				float4 v0 = float4(-0.5, 0, 0, 1);
				float4 v1 = float4(-0.5, 1, 0, 1);
				float4 v2 = float4( 0.5, 1, 0, 1);
				float4 v3 = float4( 0.5, 0, 0, 1);

				ApplyTransformAnimation(v0, _TransformAnimParams, _EditorTime);
				ApplyTransformAnimation(v1, _TransformAnimParams, _EditorTime);
				ApplyTransformAnimation(v2, _TransformAnimParams, _EditorTime);
				ApplyTransformAnimation(v3, _TransformAnimParams, _EditorTime);

				float3 q = quadIntersect(ro, rd, v0, v1, v2, v3);
				if (q.x > 0)
				{
					rayLength = q.x;
					color = float3(q.yz, 0);
					normal = float3(0, 0,-1);
					type = 2;
				}

				float3 sky = float3(0.4, 0.6, 1.0) * 1.5;
				float3 lightDir = normalize(float3(-0.5, 1, -1));
				float shadow = type != 1 || quadIntersect(groundPos, lightDir, v0, v1, v2, v3).x < 0;
				color *= saturate(dot(normal, lightDir)) * shadow * 3 + 0.5;
				sky += exp(-abs(rd.y) * 20);
				float fog = exp(-rayLength * 0.02);
				color = lerp(sky, color, fog);
				color = 1.0 - exp(-color);

				return float4(color, 1);
			}
			ENDHLSL
		}
	}
}
