using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {
    public GameObject projectile, gun;
    private GameObject projectileParent;
    private Animator a;
    private spwaner s;
    void Start()
    {
        a = GameObject.FindObjectOfType<Animator>();
        projectileParent = GameObject.Find("projectiles");
        if (!projectileParent)
        {
            projectileParent = new GameObject("projectiles");
        }
        setMyLaneSpawner();

    }
    void Update()
    {
        if (isAttackerAheadInLane())
        {
            a.SetBool("isAttacking", true);
        }
        else
        {
            a.SetBool("isAttacking", false);
        }
    }
    void setMyLaneSpawner()
    {
        spwaner [] spawnerArray = GameObject.FindObjectsOfType<spwaner>();
        foreach(spwaner thisSpwaner in spawnerArray)
        {
            if (thisSpwaner.transform.position.y == transform.position.y)
            {
                s = thisSpwaner;
                return;
            }
        }
    }
    bool isAttackerAheadInLane()
    {
        if (s.transform.childCount <= 0)
            return false;
        foreach(Transform attacker in s.transform)
        {
            if (attacker.transform.position.x > transform.position.x)
            {
                return true;
            }
        }
        return false;
    }
    public void fire()
    {
        GameObject newProjectile = Instantiate(projectile) as GameObject;
        newProjectile.transform.parent = projectileParent.transform;
        newProjectile.transform.position = gun.transform.position;
    }
}
