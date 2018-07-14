using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defenders : MonoBehaviour {
    private stardisplay s;
    public int starcost=100;
    void Start()
    {
        s = GameObject.FindObjectOfType<stardisplay>();
    }
	public void Addstars(int amount)
    {
        s.Addstars(amount);
    }
}
