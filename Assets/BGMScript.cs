using UnityEngine;
using System.Collections;

public class BGMScript : MonoBehaviour {
	private AudioSource audio;
	public AudioClip BGM;

	// Use this for initialization
	void Start () {
		this.audio = this.gameObject.AddComponent<AudioSource> ();
		this.audio.clip = this.BGM;
		this.audio.loop = true;

	}
	
	// Update is called once per frame
	void Update () {
		this.audio.Play ();
	}
}
