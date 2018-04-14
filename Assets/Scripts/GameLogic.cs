using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {
	public float movementSpeed = 2;
	public float rotationTime = 5;

	public GameObject player;
	public GameObject startUI;
	public GameObject restartUI;
	public GameObject startPoint;
	public GameObject[] showPoints;

	public GameObject pieceFallActivationShowPoint;
	public GameObject[] fallingPieces;

	private uint showPointIndex = 0;

	// Use this for initialization
	void Start () {
		player.transform.position = startPoint.transform.position;
		MoveToNextPoint ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MoveToNextPoint()
	{
		if (showPointIndex < showPoints.Length) {
			Vector3 nextPoint = showPoints [showPointIndex].transform.position;
			float distance = Vector3.Distance (player.transform.position, nextPoint);
			iTween.MoveTo(player, 
				iTween.Hash(
					"position", showPoints[showPointIndex].transform.position,
					"orienttopath", true,
					"lookTime", rotationTime,
					"time", distance/movementSpeed, 
					"easetype", "linear",
					"oncomplete", "MoveToNextPointComplete",
					"oncompletetarget", this.gameObject
				)
			);

			if (showPointIndex == 2) {
				foreach (GameObject fallingPiece in fallingPieces) {
					fallingPiece.GetComponent<Rigidbody> ().useGravity = true;
				}
			}

			showPointIndex++;
		}
	}

	public void MoveToNextPointComplete()
	{
		MoveToNextPoint ();
	}
}
