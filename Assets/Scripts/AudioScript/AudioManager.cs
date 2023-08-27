using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public AudioSource bgmAudioSource;
	public GameObject sfxAudioSource;


	private void Start()
	{
		// jalankan BGM saat game dimulai
		PlayBGM();
	}

	// fungsi yang disiapkan untuk perintah menjalankan bgm dari script lain
	public void PlayBGM() 
	{
		bgmAudioSource.Play();
	}
	// fungsi yang disiapkan untuk perintah menjalankan sfx dari script lain
	public void PlaySFX( Vector3 spawnPosition) 
	{
		GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
	}
}
