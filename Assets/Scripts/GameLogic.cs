using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour {
	public float movementSpeed = 2;
	public float rotationTime = 5;

	public GameObject player;
	public GameObject startUI;
	public GameObject restartUI;
	public GameObject startPoint;
	public GameObject[] blueShowPoints;
	public GameObject[] redShowPoints;
	private GameObject[] showPoints;

	public GameObject pieceFallActivationShowPoint;
	public GameObject[] fallingPieces;

	public GameObject finalCheese;
	public GvrAudioSource levelCompleteAudioSource;

	private uint showPointIndex = 0;

	void Start () {
		player.transform.position = startPoint.transform.position;
		player.transform.rotation = startPoint.transform.rotation;
	}

	public void StartBluePath()
	{
		showPoints = blueShowPoints;
		MoveToNextPoint ();
	}

	public void StartRedPath()
	{
		showPoints = redShowPoints;
		MoveToNextPoint ();
	}

	private void MoveToNextPoint()
	{
		if (showPointIndex < showPoints.Length) {
			Vector3 nextPoint = showPoints [showPointIndex].transform.position;
			float distance = Vector3.Distance (player.transform.position, nextPoint);
			iTween.MoveTo (player, 
				iTween.Hash (
					"position", showPoints [showPointIndex].transform.position,
					"orienttopath", true,
					"lookTime", rotationTime,
					"time", distance / movementSpeed, 
					"easetype", "linear",
					"oncomplete", "MoveToNextPointComplete",
					"oncompletetarget", this.gameObject
				)
			);

			if (showPointIndex == 2) {
				foreach (GameObject fallingPiece in fallingPieces) {
					fallingPiece.GetComponent<Rigidbody> ().useGravity = true;
					fallingPiece.SetActive (true);
				}
			}

			showPointIndex++;
		} else {
			levelCompleteAudioSource.Play ();
		}
	}

	private void MoveToNextPointComplete()
	{
		MoveToNextPoint ();
	}

	public void cheeseClicked()
	{
		if (player.transform.position == showPoints[showPoints.Length-1].transform.position) {
			SceneManager.LoadScene (1);
		}
	}
}
