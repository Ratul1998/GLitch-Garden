using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackers : MonoBehaviour {
    [Range(-1f,1.5f)]
    public float walkspeed;
    [Tooltip("Average Number Of Seconds Between Appearences")]
    public float seenEverySeconds;
    private Animator a;
    private GameObject currenttarget;
	void Start () {
        a = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * walkspeed * Time.deltaTime);
        if (!currenttarget)
        {
            a.SetBool("isAttacking",false);
        }
	}
   
    void OnTriggerEnter2D()
    {
         

    }
    public void StrikeCurrentTarget(float damage)
    {
       
        if (currenttarget)
        {
            Health h = currenttarget.GetComponent<Health>();
            if (h)
            {
                h.DealDamage(damage);
            }
        }

    }
    public void SetSpeed(float speed)
    {
        walkspeed = speed;

    }
    public void attack(GameObject obj)
    {
        currenttarget = obj;


    }
}

