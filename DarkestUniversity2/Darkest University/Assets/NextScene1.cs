using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NextScene1 : MonoBehaviour {

	public Button playB;
	public Button quitB;

	// Use this for initialization
	void Start () {

		playB.onClick.AddListener (() => {
			Application.LoadLevel("Learn");
		});

		quitB.onClick.AddListener (() => {
			Application.Quit();
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
