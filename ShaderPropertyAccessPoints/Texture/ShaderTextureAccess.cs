// Author: Anja Haumann 2022 - MIT License
// Explanation and more content at my blog: http://anja-haumann.de/unity-easy-shader-property-access/

using UnityEngine;

public class ShaderTextureAccess : ShaderPropertyAccessPoint<Texture>
{
	public ShaderTextureAccess(Renderer targetRenderer, string shaderPropertyName) : base(targetRenderer, shaderPropertyName)
	{ }

	public override Texture Get()
	{
		return referenceMaterial.GetTexture(shaderPropertyID);
	}

	public override void Set(Texture value)
	{
		referenceMaterial.SetTexture(shaderPropertyID, value);
	}
}
