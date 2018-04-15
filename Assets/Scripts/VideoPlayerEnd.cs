﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoPlayerEnd : MonoBehaviour {
	public UnityEngine.Video.VideoPlayer videoPlayer;

	void Update () {
		long frameCount = (long)videoPlayer.frameCount;

		if (videoPlayer.frame >= frameCount) { 
			SceneManager.LoadScene (0);
		}
	}
}
