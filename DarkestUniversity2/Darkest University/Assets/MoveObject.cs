using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {
	public GameObject moveBed;
	private int MoveIs=0;
	void Update (){
		if (MoveIs == 1) {
			Debug.Log("TEST1");
			moveBed.gameObject.GetComponent<Animator> ().SetTrigger ("MoveBed");
			MoveIs = 2;
			//MoveIs = false;
		}

	}


	void OnTriggerEnter (Collider coll){
		if (coll.gameObject.tag == "Player" && MoveIs == 0) {
			MoveIs = 1;
			Debug.Log (coll.gameObject.tag);
			//Update ();


		}

	}




}
