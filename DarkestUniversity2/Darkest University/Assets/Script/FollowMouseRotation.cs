﻿using UnityEngine;
using System.Collections;

public class FollowMouseRotation : MonoBehaviour {
	private float lookAngle;
	public float turnSpeed;

	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
	}


	void Update () {
		float x = Input.GetAxis ("Mouse X");

		lookAngle += x * turnSpeed;

		transform.localRotation = Quaternion.Euler (0f, lookAngle, 0f);
	}
}
