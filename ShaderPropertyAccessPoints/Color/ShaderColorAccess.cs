// Author: Anja Haumann 2022 - MIT License
// Explanation and more content at my blog: http://anja-haumann.de/unity-easy-shader-property-access/

using UnityEngine;

public class ShaderColorAccess : ShaderPropertyAccessPoint<Color>
{
	public ShaderColorAccess(Renderer targetRenderer, string shaderPropertyName) : base(targetRenderer, shaderPropertyName)
	{ }

	public override Color Get()
	{
		return referenceMaterial.GetColor(shaderPropertyID);
	}

	public override void Set(Color value)
	{
		referenceMaterial.SetColor(shaderPropertyID, value);
	}
}
