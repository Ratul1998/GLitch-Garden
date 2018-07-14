using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicmanager : MonoBehaviour {
    public AudioClip[] levelmanagermusic;
    private AudioSource a;
	
	void Awake () {
        DontDestroyOnLoad (gameObject); 
	}
	
	
	void Start() {
        a = GetComponent<AudioSource>();

	}
    void OnLevelWasLoaded(int level)
    {
        AudioClip thislevelMusic = levelmanagermusic[level];
        if (thislevelMusic)
        {
            a.clip = thislevelMusic;
            a.loop = true;
            a.Play();
        }

    }
    public void ChangeVolume(float value)
    {
        a.volume = value;
    }
}
