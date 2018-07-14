using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {
    public Slider volume;
    public Slider difficulty;
    public LevelManager l;

    private musicmanager m;

	void Start () {
        volume.value=PlayerPrefsManager.GetMasterVolume();
        difficulty.value=PlayerPrefsManager.GetDifficulty();
        m = GameObject.FindObjectOfType<musicmanager>();
        l = GameObject.FindObjectOfType<LevelManager>();
    }
	public void SaveAndExit()
    {
        PlayerPrefsManager.setdifficulty(difficulty.value);
        PlayerPrefsManager.setmasterVolume(volume.value);
        l.LoadLevel("_01 Start Menu");
    }
    public void Default()
    {
        volume.value = 0.6f;
        difficulty.value = 0.3f;
    }
    void Update()
    {
        m.ChangeVolume(volume.value);
    }
	
}
