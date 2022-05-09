// Author: Anja Haumann 2022 - MIT License
// Explanation and more content at my blog: http://anja-haumann.de/unity-easy-shader-property-access/

using UnityEngine;

public class ShaderFloatAccess : ShaderPropertyAccessPoint<float>
{
	public ShaderFloatAccess(Renderer targetRenderer, string shaderPropertyName) : base(targetRenderer, shaderPropertyName)
	{ }

	public override float Get()
	{
		return referenceMaterial.GetFloat(shaderPropertyID);
	}

	public override void Set(float value)
	{
		referenceMaterial.SetFloat(shaderPropertyID, value);
	}
}
