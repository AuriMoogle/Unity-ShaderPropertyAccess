// Author: Anja Haumann 2022 - MIT License
// Explanation and more content at my blog: http://anja-haumann.de/unity-easy-shader-property-access/

using UnityEngine;

public class ShaderAccessExample : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer spriteRenderer;

	[SerializeField]
	private float duration = 3f;

	private float elapsedTime = 0;

	private ShaderColorAccess colorAccess;

	void Start()
	{
		colorAccess = new ShaderColorAccess(spriteRenderer, "_Color");
	}

	void Update()
	{
		elapsedTime += Time.deltaTime;
		elapsedTime %= duration;

		Color newColor = Color.Lerp(Color.yellow, Color.blue, elapsedTime / duration);

		colorAccess.Set(newColor);
	}
}
