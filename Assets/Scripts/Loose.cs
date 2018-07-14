using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loose : MonoBehaviour {
    private LevelManager l;
	// Use this for initialization
	void Start () {
        l = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
        l.LoadLevel("Losescreen");
        
    }
}
