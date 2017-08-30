using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float baseSpeed;
	public float jumpHeight;

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;

	private Rigidbody2D character;

	private bool grounded;
	private int jumps = 2;
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
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
		if (grounded)
			jumps = 2;

		if (Input.GetKey (KeyCode.LeftShift) && walkingSpeed < maxRunSpeed)
			walkingSpeed += runningAccel;
		else if (!Input.GetKey(KeyCode.LeftShift) && walkingSpeed > baseSpeed)
			walkingSpeed -= runningAccel;

		float moveHorz = Input.GetAxis ("Horizontal");
		Vector2 movement = new Vector2 (moveHorz * walkingSpeed, character.velocity.y);
		if (Input.GetButtonDown ("Jump") && (grounded || jumps-- > 0)) {
			movement.y = jumpHeight;
		}
		character.velocity = movement;
	}
}
