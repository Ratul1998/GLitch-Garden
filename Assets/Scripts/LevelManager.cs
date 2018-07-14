using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public int autoloadnextlevelafter;
    void Start()
    {
        if(autoloadnextlevelafter!=0)
            Invoke ("LoadNextLevel",autoloadnextlevelafter);

    }
	public void LoadNextLevel () {
        Application.LoadLevel(Application.loadedLevel+1);
    }
	
	public void LoadLevel(string name)
    {
        Application.LoadLevel(name);
    }
	public void quitrequested () {
        Application.Quit();
	}

}
