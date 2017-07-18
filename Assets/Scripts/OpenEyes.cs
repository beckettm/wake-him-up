using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenEyes : MonoBehaviour {

	public Sprite[] eyeSprites;
	public GameObject eyes;
	public AudioSource music;

	void OnCollisionEnter() {
		eyes.GetComponent<SpriteRenderer>().sprite = eyeSprites[1];
		music.Play();
	}

}
