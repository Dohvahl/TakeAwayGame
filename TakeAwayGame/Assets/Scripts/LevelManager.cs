using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;
	public PlayerController player;

	public void RespawnPlayer()
	{
		player.transform.position = currentCheckpoint.transform.position;
	}

	public void UpdateCheckpoint (GameObject checkpoint)
	{
		currentCheckpoint = checkpoint;
	}
}
