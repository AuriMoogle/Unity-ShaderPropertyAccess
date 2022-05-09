// Author: Anja Haumann 2022 - MIT License
// Explanation and more content at my blog: http://anja-haumann.de/unity-easy-shader-property-access/

using UnityEngine;

public abstract class ShaderPropertyAccessPoint<T>
{
	protected int shaderPropertyID
	{
		get
		{
			// Lazy property
			if (_shaderPropertyID == -1)
				_shaderPropertyID = Shader.PropertyToID(shaderPropertyName);

			return _shaderPropertyID;
		}
	}

	private int _shaderPropertyID = -1;

	protected Material referenceMaterial
	{
		get
		{
			// Lazy property
			if (_referenceMaterial == null)
				_referenceMaterial = targetRenderer.material;

			return _referenceMaterial;
		}
	}

	private Material _referenceMaterial;

	private readonly Renderer targetRenderer;

	private readonly string shaderPropertyName;

	public ShaderPropertyAccessPoint(Renderer targetRenderer, string shaderPropertyName)
	{
		this.targetRenderer = targetRenderer;
		this.shaderPropertyName = shaderPropertyName;
	}

	public abstract void Set(T value);

	public abstract T Get();
}
