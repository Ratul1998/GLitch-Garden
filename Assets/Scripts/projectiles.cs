using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectiles : MonoBehaviour {

    public float speed;
    public float damage;
	void Start () {
		
	}
	
	
	void Update () {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        Attackers a = col.gameObject.GetComponent<Attackers>();
        Health health = col.gameObject.GetComponent<Health>();
        if (a && health)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }
    }
    
}
