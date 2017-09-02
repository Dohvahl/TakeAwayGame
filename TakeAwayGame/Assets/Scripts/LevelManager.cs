using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;
	public PlayerController player;
	public float respawnDelay;

	public void RespawnPlayer()
	{
		StartCoroutine(RespawnPlayerCo());
	}

	IEnumerator RespawnPlayerCo()
	{
		yield return new WaitForSeconds (respawnDelay);
		player.transform.position = currentCheckpoint.transform.position;
	}

	public void UpdateCheckpoint (GameObject checkpoint)
	{
		currentCheckpoint = checkpoint;
	}
}
