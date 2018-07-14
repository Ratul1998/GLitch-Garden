using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panel : MonoBehaviour {
    public float fadeintime;
    private Image Fadepanel;
    private Color currentcolor = Color.black;
	// Use this for initialization
	void Start () {
        Fadepanel = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeSinceLevelLoad < fadeintime)
        {
            float alphachange = Time.deltaTime / fadeintime;
            currentcolor.a -= alphachange;
            Fadepanel.color = currentcolor;
        }
        else
        {
            gameObject.SetActive(false);
        }
	}
}
