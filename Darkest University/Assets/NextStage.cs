using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextStage : MonoBehaviour {


	IEnumerator Pending (){
		yield return new WaitForSeconds (2f);
		SceneManager.LoadScene ("BimusStage");
	}

	void OnTriggerEnter (Collider coll){
		Debug.Log (coll.gameObject.tag);
		if (coll.gameObject.tag == "Player") {
			
			StartCoroutine (Pending());
		}

	}

}
