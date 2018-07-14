using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour {

    private Animator an;
    private Attackers l;
    
    void Start()
    {
        an = GetComponent<Animator>();
        l = GetComponent<Attackers>();
    }

    
    void OnTriggerEnter2D(Collider2D col)
    {
        GameObject obj = col.gameObject;
        if (!obj.GetComponent<Defenders>())
        {
            return;
        }
       
        an.SetBool("isAttacking", true);
        l.attack(obj);
        
        
    }
}
