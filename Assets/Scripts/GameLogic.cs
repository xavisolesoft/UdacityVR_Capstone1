using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour {
	enum ChoosenPath{
		red,
		blue
	};
	public float movementSpeed = 2;
	public float rotationTime = 5;

	public GameObject blueSphere;
	public GameObject redSphere;

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
	public GvrAudioSource levelFailedAudioSource;

	public GameObject lifeObject;
	private bool timeToLifeCounterActive = false;
	private float timeToLifeCounter;

	ChoosenPath choosenPath;

	private uint showPointIndex = 0;

	void Start () {
		player.transform.position = startPoint.transform.position;
		player.transform.rotation = startPoint.transform.rotation;

		timeToLifeCounterActive = false;
		timeToLifeCounter = 0.0f;
	}

	void Update(){
		if (timeToLifeCounterActive) {
			timeToLifeCounter += Time.deltaTime;
			if (timeToLifeCounter >= 4.0f) {
				lifeObject.SetActive (true);
				timeToLifeCounterActive = false;
				timeToLifeCounter = 0.0f;
			}
		}
	}

	public void StartBluePath()
	{
		showPoints = blueShowPoints;
		choosenPath = ChoosenPath.blue;
		blueSphere.SetActive (false);
		redSphere.SetActive (false);
		MoveToNextPoint ();
	}

	public void StartRedPath()
	{
		showPoints = redShowPoints;
		choosenPath = ChoosenPath.red;
		blueSphere.SetActive (false);
		redSphere.SetActive (false);
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
			if (choosenPath == ChoosenPath.blue) {
				levelCompleteAudioSource.Play ();
			} else {
				levelFailedAudioSource.Play ();
				timeToLifeCounterActive = true;
				timeToLifeCounter = 0.0f;
			}
		}
	}

	private void MoveToNextPointComplete()
	{
		MoveToNextPoint ();
	}

	public void lifeClicked ()
	{
		SceneManager.LoadScene (0);
	}

	public void cheeseClicked()
	{
		if (player.transform.position == showPoints[showPoints.Length-1].transform.position) {
			SceneManager.LoadScene (1);
		}
	}
}
