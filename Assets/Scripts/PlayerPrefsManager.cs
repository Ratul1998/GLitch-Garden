using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsManager : MonoBehaviour {
    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFFICULTY_KEY = "difficulty";
    const string LEVEL_KEY = "level_unlock";
    
    public static void setmasterVolume(float volume)
    {
        if (volume > 0f && volume <= 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }

    }
    public static void setdifficulty(float value)
    {
        if (value > 0f && value <= 1f)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, value);
        }

    }
    public static float GetMasterVolume()
    {
       return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }
    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }

}
