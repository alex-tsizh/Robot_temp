using System.Collections;
using UnityEngine;
[RequireComponent (typeof(AudioSource))]
public class ControllerAudio : MonoBehaviour {

	public AudioClip audioEnter;
	public AudioClip audioInt1;
	public AudioClip audioInt2;

	private AudioSource audio;

	void Start()
	{
		audio = GetComponent <AudioSource> ();
	}


	void AudioEnterPlay()
	{
		audio.clip = audioEnter;
		audio.Play ();
	}

	void AudioInt1Play()
	{
		audio.clip = audioInt1;
		audio.Play ();
	}

	void AudioInt2Play()
	{
		audio.clip = audioInt2;
		audio.Play ();
	}
}
