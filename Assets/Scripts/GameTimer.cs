using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {
    public float levelSeconds=100;
    private Slider s;
    private AudioSource a;
    private bool isEndOfLevel = false;
    private LevelManager l;
    public GameObject winlable;
	void Start () {
        s = GetComponent<Slider>();
        a = GetComponent<AudioSource>();
        l = GameObject.FindObjectOfType<LevelManager>();
        winlable.SetActive(false);
	}
	
	
	void Update () {
        s.value = (Time.timeSinceLevelLoad / levelSeconds);
        if(Time.timeSinceLevelLoad>=levelSeconds&& !isEndOfLevel)
        {
            a.Play();
            winlable.SetActive(true);
            Invoke("LoadNextLevel", a.clip.length);
            isEndOfLevel = true;
        }

        
	}
    void LoadNextLevel()
    {
        l.LoadNextLevel();
    }
}
