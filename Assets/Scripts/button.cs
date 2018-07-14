using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class button : MonoBehaviour {
    public GameObject defenderPrefab;
    public button[] buttonarray;
    public static GameObject selectdefender;
    private Text costText;
	
	void Start () {
        GetComponent<SpriteRenderer>().color = Color.black;
        buttonarray = GameObject.FindObjectsOfType<button>();
        costText = GetComponentInChildren<Text>();
        costText.text = defenderPrefab.GetComponent<Defenders>().starcost.ToString();
	}
	
	
	void Update () {
		
	}
    void OnMouseDown()
    {
        foreach(button thisbutton in buttonarray)
        {
            thisbutton.GetComponent<SpriteRenderer>().color = Color.black;
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        selectdefender = defenderPrefab;
    }
}
