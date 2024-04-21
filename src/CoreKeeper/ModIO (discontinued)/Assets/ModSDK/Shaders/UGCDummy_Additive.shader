Shader "UGC_Dummy/Additive"
{
	Properties
	{
		[PerRendererData] _MainTex ("Texture", 2D) = "white" {}
	}
	SubShader
	{
		Tags { "RenderType"="Transparent" "Queue"="Transparent" }

		Cull Off

		Pass
		{
			Blend One One
			ZWrite Off
			ColorMask RGB
			
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			#include "UnityCG.cginc"

			sampler2D _MainTex;
			float4 _MainTex_ST;

			struct appdata
			{
				float4 vertex : POSITION;
				float4 color : COLOR;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float4 vertex : SV_POSITION;
				float4 color : COLOR;
				float2 uv : TEXCOORD0;			
			};

			v2f vert(appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.color = v.color;
				o.uv = v.uv;
				return o;
			}

			float4 frag(v2f i) : SV_Target
			{
				float4 color = tex2D(_MainTex, i.uv) * i.color;
				return color * color.a;
			}
			ENDCG
		}
	}
}
