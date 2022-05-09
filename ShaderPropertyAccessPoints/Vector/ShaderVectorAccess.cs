// Author: Anja Haumann 2022 - MIT License
// Explanation and more content at my blog: http://anja-haumann.de/unity-easy-shader-property-access/

using UnityEngine;

public class ShaderVectorAccess : ShaderPropertyAccessPoint<Vector4>
{
	public ShaderVectorAccess(Renderer targetRenderer, string shaderPropertyName) : base(targetRenderer, shaderPropertyName)
	{ }

	public override Vector4 Get()
	{
		return referenceMaterial.GetVector(shaderPropertyID);
	}

	public override void Set(Vector4 value)
	{
		referenceMaterial.SetVector(shaderPropertyID, value);
	}
}
