using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour {
	public string sceneName;
	private bool readySave = false;
	private Vector3 playerPos;

	// Use this for initialization
	void Start () {
		readySave = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) {
			PlayerPrefs.SetFloat ("x", transform.position.x);
			PlayerPrefs.SetFloat ("y", transform.position.y);
			PlayerPrefs.SetFloat ("z", transform.position.z);
			PlayerPrefs.SetString ("scene", sceneName);
			Debug.Log ("Player Saved");
		}
	}

	void OnTriggerStay (Collider col) {
		if (col.gameObject.tag == "Player") {
			readySave = true;
			playerPos = col.gameObject.transform.position;

		}
	}
	void OnTriggerExit (Collider col) {
		if (col.gameObject.tag == "Player") {
			readySave = false;
		}
	}


}
