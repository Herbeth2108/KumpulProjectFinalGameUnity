using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenuEsc : MonoBehaviour {

	public GameObject menu;
	private bool isShowing=false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("escape")) {
			Debug.Log ("Test");
			isShowing = !isShowing;
			menu.SetActive (isShowing);

			if (isShowing) {
				Cursor.lockState = CursorLockMode.None;
			} else {
				Cursor.lockState = CursorLockMode.Locked;
			}
		}
	}
}
