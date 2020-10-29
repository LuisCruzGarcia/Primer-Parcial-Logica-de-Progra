using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
	private float speed = 200.0f;
	void Update()
    {
		float translation = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		transform.Translate(translation, 0, 0);
	}
}
