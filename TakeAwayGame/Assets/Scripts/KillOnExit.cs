using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnExit : MonoBehaviour {

	public LevelManager levelManager;

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.tag == "Player")
			levelManager.RespawnPlayer ();
		else
			Destroy (other.gameObject);
		
	}
}
