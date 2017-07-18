using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartInput : MonoBehaviour {

	public float MoveSpeed;

	void Update () {
		if (Input.GetKey(KeyCode.Space)) {
			gameObject.transform.Translate(new Vector3 (0f, 0f, -MoveSpeed));
		}
	}
}
