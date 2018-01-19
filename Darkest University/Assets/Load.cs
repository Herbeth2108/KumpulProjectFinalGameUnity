using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour {

	// Use this for initialization
	public void click () {
		
		if (PlayerPrefs.HasKey ("scene")) {
			SceneManager.LoadScene (PlayerPrefs.GetString ("scene"));
			}
		}
	
	// Update is called once per frame
	void Update () {
		
	}
}
