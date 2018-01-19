using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DestroyOnTouch : MonoBehaviour {

	// Use this for initialization
	public Text orbsText;
	public int orbsCount;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Orb") {
			Debug.Log ("A");
			Destroy (col.gameObject);
			orbsCount++;
			orbsText.text = orbsCount.ToString ();
		}
	}

}
