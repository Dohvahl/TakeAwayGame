using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

	private LevelManager levelManager;

	void Start ()
	{
		levelManager = FindObjectOfType<LevelManager> ();
	}

	void OnTriggerEnter2D ()
	{
		levelManager.UpdateCheckpoint (gameObject);
	}
}
