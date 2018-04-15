using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnColision : MonoBehaviour {
	public GvrAudioSource audioSource;

	void OnCollisionEnter(Collision collision){
		audioSource.Play ();
	}
}
