﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextSceneFinal : MonoBehaviour {

	public DestroyOnTouch DOT;
	private bool isActive;
	public GameObject Text;
	// Use this for initialization
	void Start () {
		isActive = false;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z) && isActive) {

			if (DOT.orbsCount >= 10) {
				SceneManager.LoadScene ("FinalScene");
			} else {
				Text.SetActive (true);

			}
		}
	}
	void OnTriggerStay(Collider coll) {
		if (coll.gameObject.tag == "Player") {
			isActive = true;
		}
	}

	void OnTriggerExit(Collider coll) {
		if (coll.gameObject.tag == "Player") {
			isActive = false;
			Text.SetActive (false);
		}
	}
}
