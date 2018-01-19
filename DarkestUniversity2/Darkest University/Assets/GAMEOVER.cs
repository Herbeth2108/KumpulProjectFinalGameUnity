using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GAMEOVER : MonoBehaviour {





	public GameObject gameOver;
	// Use this for initialization

	IEnumerator Pending ( ){
		yield return new WaitForSeconds (2f);
		SceneManager.LoadScene ("Main Menu");
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider coll)
	{
		if (coll.gameObject.tag == "Player") {
			Debug.Log ("HITTED");
			gameOver.SetActive (true);
			StartCoroutine (Pending ());

		}

	}
}
