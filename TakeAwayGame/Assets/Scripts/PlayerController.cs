using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float walkingSpeed;
	public float jumpHeight;

	private Rigidbody2D character;

	void Start()
	{
		character = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate()
	{
		float moveHorz = Input.GetAxis ("Horizontal");
		Vector2 movement = new Vector2 (moveHorz * walkingSpeed, character.velocity.y);
		if (Input.GetButtonDown ("Jump")) {
			movement.y = jumpHeight;
		}
		character.velocity = movement;
	}
}
