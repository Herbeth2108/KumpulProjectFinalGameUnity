using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {
	private bool canOpen=false;
	public float z;

	void Update (){
		if (canOpen && Input.GetKeyDown (KeyCode.Z)) {
			//Vector3 post = transform.position;
			//post.z = z;
			//transform.position = post;
			GetComponent<Animator> ().SetTrigger("Open");
		}
	
	}
	void OnTriggerEnter (Collider coll){
		if (coll.gameObject.tag == "Player") {
			canOpen = true;
			if (GetComponent<AudioSource> () != null) {
				GetComponent<AudioSource> ().Play ();
			}
		}
	
	}

	void OnTriggerExit (Collider coll){
		if (coll.gameObject.tag == "Player") {
			canOpen = false;

		}
	
	}
}
