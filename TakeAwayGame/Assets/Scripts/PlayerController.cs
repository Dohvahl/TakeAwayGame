using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float walkingSpeed;

	private CharacterController character;

	void Start()
	{
		character = GetComponent<CharacterController> ();
	}

	void FixedUpdate()
	{
		float moveHorz = Input.GetAxis ("Horizontal");
		Vector3 movement = new Vector3 (moveHorz, 0.0f, 0.0f);
		Move(transform.TransformDirection (movement), walkingSpeed);
	}

	void Move (Vector3 movement, float speed)
	{
		character.Move (movement * speed * Time.deltaTime);
	}
}
