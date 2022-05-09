// Author: Anja Haumann 2022 - MIT License
// Explanation and more content at my blog: http://anja-haumann.de/unity-easy-shader-property-access/

using UnityEngine;

public class ShaderIntAccess : ShaderPropertyAccessPoint<int>
{
	public ShaderIntAccess(Renderer targetRenderer, string shaderPropertyName) : base(targetRenderer, shaderPropertyName)
	{ }

	public override int Get()
	{
		return referenceMaterial.GetInteger(shaderPropertyID);
	}

	public override void Set(int value)
	{
		referenceMaterial.SetInteger(shaderPropertyID, value);
	}
}
