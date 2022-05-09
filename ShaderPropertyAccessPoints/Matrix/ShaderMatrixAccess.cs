// // Author: Anja Haumann 2022 - MIT License
// Explanation and more content at my blog: http://anja-haumann.de/unity-easy-shader-property-access/

using UnityEngine;

public class ShaderMatrixAccess : ShaderPropertyAccessPoint<Matrix4x4>
{
	public ShaderMatrixAccess(Renderer targetRenderer, string shaderPropertyName) : base(targetRenderer, shaderPropertyName)
	{ }

	public override Matrix4x4 Get()
	{
		return referenceMaterial.GetMatrix(shaderPropertyID);
	}

	public override void Set(Matrix4x4 value)
	{
		referenceMaterial.SetMatrix(shaderPropertyID, value);
	}
}
