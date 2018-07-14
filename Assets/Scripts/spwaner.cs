using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwaner : MonoBehaviour {
    public GameObject[] attackerprefabArray;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		foreach(GameObject thisAttacker in attackerprefabArray)
        {
            if (isTimeToSpawn(thisAttacker))
            {
                Spawn(thisAttacker);
            }
        }
	}
    bool isTimeToSpawn(GameObject attackerObject)
    {
        Attackers a = attackerObject.GetComponent<Attackers>();
        float meanSpwanDelay = a.seenEverySeconds;
        float spawnpersecond = 1 / meanSpwanDelay;
        if(Time.deltaTime>meanSpwanDelay)
        {
            Debug.LogWarning("Spawn rate capped by frame rate");
        }
        float threshold = (spawnpersecond * Time.deltaTime)/5;
        return (Random.value < threshold);
    }
    void Spawn(GameObject mygameObj)
    {
        GameObject myattacker = Instantiate(mygameObj) as GameObject;
        myattacker.transform.parent = transform;
        myattacker.transform.position = transform.position;
    }
}
