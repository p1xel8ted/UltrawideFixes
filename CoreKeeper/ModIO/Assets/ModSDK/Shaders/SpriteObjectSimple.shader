Shader "SpriteObject/Simple"
{
	////////////////////////////////////////////////////////////////////////////////////////
	/// Basic opaque (alpha tested) SpriteObject shader with everything required to function
	////////////////////////////////////////////////////////////////////////////////////////
	
	SubShader
	{
		Tags { "RenderType"="Opaque" "Queue"="Geometry" }

		Cull Off

		Pass
		{
			CGPROGRAM
			#pragma require instancing
			#pragma vertex vert
			#pragma fragment frag
			#pragma multi_compile_instancing
			#pragma multi_compile _ INSTANCING_ENABLED

			#define PPU 16
			#define INSTANCING_ON

			#include "UnityCG.cginc"
			#include "SpriteObject.hlsl"
			#include "SpriteObjectInput.hlsl"

			float4 frag(v2f i) : SV_Target
			{
				float4 colorAlpha;
				float3 emission, normal;
				GetSpriteColor(i, colorAlpha, emission, normal);

				clip(colorAlpha.a - 0.5);

				colorAlpha.rgb *= colorAlpha.a;

				colorAlpha.rgb += emission;

				return colorAlpha;
			}
			ENDCG
		}
	}
}
