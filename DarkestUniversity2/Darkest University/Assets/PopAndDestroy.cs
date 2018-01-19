using UnityEngine;
using System.Collections;

public class PopAndDestroy : MonoBehaviour
{
	public bool activateTrigger = false;

	public GameObject textO;
	public GameObject Sound;

	IEnumerator Pending (){
		yield return new WaitForSeconds (3f);
		textO.SetActive(false);
		Destroy(this.gameObject);

	}

	void Start()
	{
		textO.SetActive(false);
		Sound.SetActive(false);
	}


	void Update()
	{
		if (activateTrigger == true)
		{
			StartCoroutine (Pending());
		
		}

	}


	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			textO.SetActive(true);
			Sound.SetActive(true);
			activateTrigger = true;
			Sound.SetActive(true);


		}

	}


	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			//textO.SetActive(false);
			//activateTrigger = false;
			//Destroy(this.gameObject);
		}

	}
}