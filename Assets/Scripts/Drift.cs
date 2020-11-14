using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drift : MonoBehaviour
{
	public Vector2 driftVelocity = Vector2.down;

	void Start()
	{
	}

	void Update()
	{
		transform.Translate(driftVelocity * Time.deltaTime);
	}
}
