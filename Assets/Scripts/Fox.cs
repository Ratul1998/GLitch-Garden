using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour {
    private Animator a;
    private Attackers f;
	
	void Start () {
        a = GetComponent<Animator>();
        f = GetComponent<Attackers>();
    }
	
	
    void OnTriggerEnter2D(Collider2D col)
    {
        GameObject obj = col.gameObject;
        if (!obj.GetComponent<Defenders>())
        {
            return;
        }
        if (obj.GetComponent<Grave>())
        {
            a.SetTrigger("JumpTrigger");
        }
        else
        {
            a.SetBool("isAttacking", true);
            f.attack(obj);
        }
    }
}
