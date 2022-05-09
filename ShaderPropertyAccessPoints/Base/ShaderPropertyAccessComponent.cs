// Author: Anja Haumann 2022 - MIT License
// Explanation and more content at my blog: http://anja-haumann.de/unity-easy-shader-property-access/

using System;
using UnityEngine;

public class ShaderPropertyAccessComponent<T, P> : MonoBehaviour where T : ShaderPropertyAccessPoint<P>
{
	[SerializeField]
	private Renderer targetRenderer;

	[SerializeField]
	private string shaderPropertyName;

	private T propertyAccessor;

	public P Get()
	{
		EnsureAccessValid();
		return propertyAccessor.Get();
	}

	public void Set(P value)
	{
		EnsureAccessValid();
		propertyAccessor.Set(value);
	}

	private void EnsureAccessValid()
	{
		if (propertyAccessor == null)
		{
			// As far as I know C# does not support calling constructors
			// with parameters on generic types -> use the activator instead.
			propertyAccessor = (T)Activator.CreateInstance(
				typeof(T),
				targetRenderer,
				shaderPropertyName);
		}
	}
}

