#ifndef SPRITE_INSTANCING_STANDARD_INCLUDED
#define SPRITE_INSTANCING_STANDARD_INCLUDED

struct appdata
{
	float4 vertex : POSITION;
	float3 normal : NORMAL;
	float4 tangent : TANGENT;
	float2 uv : TEXCOORD0;

	UNITY_VERTEX_INPUT_INSTANCE_ID
};

struct v2f
{
	float4 vertex : SV_POSITION;
	float3 positionWS : TEXCOORD1;
	float3 normal : NORMAL;
	float3 tangent : TANGENT;
	float4 color : COLOR;
	float2 uv : TEXCOORD0;
	float4 rect : TEXCOORD2;
	float2 pivot : TEXCOORD3;
	float4 emissiveColor : TEXCOORD4;
	float4 flashColor : TEXCOORD5;
	float4 outlineColor : TEXCOORD6;
	float3 gradientIndices : TEXCOORD7;
	float4 screenPos : TEXCOORD8;
#if PIVOT_DEPTH_PROJECTION
	float3 worldSpacePivot : TEXCOORD9;
#endif
};

void GetSpriteColor(v2f i, out float4 colorAlpha, out float3 emission, out float3 normal)
{
	float2 uv = GetUV(i.uv, i.rect);

	colorAlpha = GetColor(uv);
	s_tallMask = step(0.95, colorAlpha.a);
	colorAlpha.rgb = SampleGradients(colorAlpha.rgb, i.gradientIndices);

	float insideRect = all(abs(i.uv - 0.5) < 0.5);

	colorAlpha *= insideRect; // Force 0 alpha for outline padding pixels

	float outline = GetOutline(i.uv, i.rect);
	outline = max(0, outline - colorAlpha.a);

	colorAlpha *= i.color;

	colorAlpha.a = max(colorAlpha.a, outline * i.outlineColor.a);

	colorAlpha.rgb *= 1.0 - max(i.flashColor.a, outline);

	float4 emissive = GetEmissive(uv) * insideRect;
	emissive.rgb *= i.emissiveColor.rgb * emissive.a;

	colorAlpha.rgb = max(0.0, colorAlpha.rgb - emissive.rgb);

	emission = emissive.rgb;
	emission += i.flashColor.rgb * i.flashColor.a * (1.0 - outline * i.outlineColor.a);
	emission += i.outlineColor.rgb * outline * i.outlineColor.a;

	float3 normalTS = GetNormal(uv);

	float3 binormal = normalize(cross(i.tangent, i.normal));
	normal = normalTS.x * i.tangent + normalTS.y * binormal + normalTS.z * i.normal;
}

v2f vert(appdata v)
{
	v2f o;

#if INSTANCING_ENABLED && defined(UNITY_INSTANCING_ENABLED)
	InstanceData instanceData = _InstanceData[UNITY_GET_INSTANCE_ID(v)];
	float4x4 localToWorld = instanceData.localToWorld;
	o.pivot = instanceData.pivot;
	o.rect = instanceData.rect;
	float4 color = instanceData.color;
	float4 emissiveColor = instanceData.emissiveColor;
	o.flashColor = instanceData.flashColor;
	o.outlineColor = instanceData.outlineColor;
	o.gradientIndices = instanceData.gradientIndices;
	float3 transformAnimParams = instanceData.transformAnimParams;
#else
	float4x4 localToWorld = UNITY_MATRIX_M;
	o.pivot = _Pivot;
	o.rect = _Rect;
	float4 color = _Color;
	float4 emissiveColor = _EmissiveColor;
	o.flashColor = _FlashColor;
	o.outlineColor = _OutlineColor;
	o.gradientIndices = _GradientIndices;
	float3 transformAnimParams = _TransformAnimParams;
#endif

	// Snap pivot to rect pixels. This prevents aliasing if the fed pivot data was misaligned (such as when inheriting a pivot from a rect of a different size)
	o.pivot = round(o.pivot * o.rect.zw) / o.rect.zw;

	// 1px padding for outline support
	float2 paddedSize = o.rect.zw + 2;
	v.vertex.xy *= paddedSize / o.rect.zw;
	v.vertex.xy -= 1.0 / o.rect.zw;
	v.uv *= paddedSize / o.rect.zw;
	v.uv -= 1.0 / o.rect.zw;

	v.vertex.xy -= o.pivot;
	
	v.vertex.xy *= o.rect.zw / PPU;

	if (transformAnimParams.x > -1)
	{
#if INSTANCING_ENABLED && defined(UNITY_INSTANCING_ENABLED)
		float time = _Time.y;
#else
		float time = _EditorTime;
#endif
		ApplyTransformAnimation(v.vertex, transformAnimParams, time);
	}

	o.positionWS = mul(localToWorld, v.vertex);
	o.normal = normalize(mul((float3x3)localToWorld, v.normal));
	o.tangent = normalize(mul((float3x3)localToWorld, v.tangent.xyz));

	o.vertex = mul(UNITY_MATRIX_VP, float4(o.positionWS, 1.0));
	o.uv = v.uv;

	o.color = color;
	o.emissiveColor = emissiveColor;

	o.screenPos = ComputeScreenPos(o.vertex);

#if PIVOT_DEPTH_PROJECTION
	o.worldSpacePivot = mul(localToWorld, float4(0.0, 0.0, 0.0, 1.0)).xyz;
#endif

	return o;
}

#endif // SPRITE_INSTANCING_STANDARD_INCLUDED