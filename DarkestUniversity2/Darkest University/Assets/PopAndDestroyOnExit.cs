using UnityEngine;
using System.Collections;

public class PopAndDestroyOnExit : MonoBehaviour
{
	public bool activateTrigger = false;

	public GameObject textO;
	public GameObject Sound;


	void Start()
	{
		textO.SetActive(false);
		Sound.SetActive(false);
	}


	void Update()
	{

	}


	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			textO.SetActive(true);
			activateTrigger = true;
			Sound.SetActive(true);
		}

	}


	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			textO.SetActive(false);
			activateTrigger = false;
			Destroy (this.gameObject);
		}

	}
}