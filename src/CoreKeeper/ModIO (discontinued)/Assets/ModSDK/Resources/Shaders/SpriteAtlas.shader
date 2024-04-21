Shader "Hidden/SpriteAtlas"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
	}
	SubShader
	{
		Cull Off
		ZTest Always
		ZWrite Off
		// ZClip Off

		CGINCLUDE
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

		sampler2D _SpriteTexture;
		float4 _SpriteColor;

		v2f vert (appdata v)
		{
			v2f o;

			o.vertex = UnityObjectToClipPos(v.vertex);
			o.uv = v.uv;

			return o;
		}

		ENDCG

		Pass // Color
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			float4 frag (v2f i) : SV_Target
			{
				return tex2D(_SpriteTexture, i.uv);
			}
			ENDCG
		}

		Pass // Normal
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			float4 frag (v2f i) : SV_Target
			{
				float3 tNormal = UnpackNormal(tex2D(_SpriteTexture, i.uv));
				return float4(tNormal * 0.5 + 0.5, 1.0);
			}
			ENDCG
		}

		/*
		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			sampler2D _Atlas;
			float4 _Atlas_TexelSize;

			v2f vert (appdata v)
			{
				v2f o;

				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;

				return o;
			}

			float4 frag (v2f i) : SV_Target
			{
				float2 srcPixel = floor(i.uv * _Atlas_TexelSize.zw);
				float checkerboard = (srcPixel.x + srcPixel.y) % 2 == 0;

				float4 tex = tex2D(_Atlas, i.uv);
				float3 color = 0.2 + checkerboard * 0.02;
				color = lerp(color, tex.rgb, tex.a);
				
				color.rgb = LinearToGammaSpace(color.rgb);

				return float4(color, 1.0);
			}
			ENDCG
		}
		*/
	}
}
