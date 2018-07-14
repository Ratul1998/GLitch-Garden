using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMasterVolume : MonoBehaviour {
    private musicmanager m;
	// Use this for initialization
	void Start () {
       m=GameObject.FindObjectOfType<musicmanager>();
        if (m)
        {
            float volume = PlayerPrefsManager.GetMasterVolume();
           
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
