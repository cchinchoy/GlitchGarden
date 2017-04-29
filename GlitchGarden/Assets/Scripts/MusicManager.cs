using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicManager;
	AudioSource audioSource;

	void Awake(){
		DontDestroyOnLoad (gameObject);
	}

	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	void OnLevelWasLoaded(int level){
		AudioClip levelMusic = levelMusicManager [level];
		if(levelMusic){
			audioSource.clip = levelMusic;
			audioSource.loop = true;
			audioSource.Play();
		}
	}

	public void ChangeVolume(float vol){
		audioSource.volume = vol;
	}
}
