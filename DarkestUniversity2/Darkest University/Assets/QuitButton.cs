﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class QuitButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void quit () {
		Application.Quit ();
	}

	public void mainmenu() {
		SceneManager.LoadScene ("Main Menu");
	}
}
