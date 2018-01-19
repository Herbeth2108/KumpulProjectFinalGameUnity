using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.HasKey ("x")) {
			transform.position = new Vector3 (
				PlayerPrefs.GetFloat("x"),
				PlayerPrefs.GetFloat("y"),
				PlayerPrefs.GetFloat("z")	
			);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
