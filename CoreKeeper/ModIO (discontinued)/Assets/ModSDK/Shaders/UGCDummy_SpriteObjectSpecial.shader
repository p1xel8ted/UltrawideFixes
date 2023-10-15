Shader "SpriteObject/Special"
{
	////////////////////////////////////////////////////////////////////////////////////////
	/// Basic opaque (alpha tested) SpriteObject shader with everything required to function
	////////////////////////////////////////////////////////////////////////////////////////
	
	SubShader
	{
		Tags { "RenderType"="Transparent" "Queue"="Transparent" }

		Cull Off
		Blend SrcAlpha OneMinusSrcAlpha
		ZWrite Off

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
			#include "Packages/dev.pugstorm.spriteinstancing/Shaders/SpriteObject.hlsl"
			#include "Packages/dev.pugstorm.spriteinstancing/Shaders/SpriteObjectInput.hlsl"

			float4 frag(v2f i) : SV_Target
			{
				float4 colorAlpha;
				float3 emission, normal;
				GetSpriteColor(i, colorAlpha, emission, normal);

				// clip(colorAlpha.a - 0.5);

				colorAlpha.rgb *= colorAlpha.a;

				colorAlpha.rgb += emission;

				return colorAlpha;
			}
			ENDCG
		}
	}
}
