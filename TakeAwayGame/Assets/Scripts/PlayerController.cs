using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float baseSpeed;
	public float jumpHeight;

	private Rigidbody2D character;

	private float walkingSpeed;
	private float maxRunSpeed = 30;
	private float runningAccel = 0.5f;

	void Start()
	{
		character = GetComponent<Rigidbody2D> ();
		walkingSpeed = baseSpeed;
	}

	void FixedUpdate()
	{
		float moveHorz = Input.GetAxis ("Horizontal");

		if (Input.GetKey (KeyCode.LeftShift) && walkingSpeed < maxRunSpeed)
			walkingSpeed += runningAccel;
		else if (!Input.GetKey(KeyCode.LeftShift) && walkingSpeed > baseSpeed)
			walkingSpeed -= runningAccel;
		
		Vector2 movement = new Vector2 (moveHorz * walkingSpeed, character.velocity.y);
		if (Input.GetButtonDown ("Jump")) {
			movement.y = jumpHeight;
		}
		character.velocity = movement;
	}
}
