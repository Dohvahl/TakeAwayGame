using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnExit : MonoBehaviour {

	public LevelManager levelManager;

	void OnTriggerExit2D(Collider2D other)
	{
		levelManager.RespawnPlayer ();
	}
}
