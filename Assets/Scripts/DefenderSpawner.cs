using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {
    public Camera myCamera;
    private GameObject DefenderParent;
    private stardisplay s;
    void Start()
    {
        s = GameObject.FindObjectOfType<stardisplay>();
        DefenderParent = GameObject.Find("Defenders");
        if (!DefenderParent)
        {
            DefenderParent = new GameObject("Defenders");
        }
    }
    void OnMouseDown()
    {
        Vector2 rawPos = CalculationOfMouseClick();
        Vector2 pos = snaptogrid(rawPos);
        GameObject defender = button.selectdefender;
        int defenderCost = defender.GetComponent<Defenders>().starcost;
        if (s.UseStars(defenderCost) == stardisplay.Status.SUCESS)
        {
            GameObject newdef = Instantiate(defender, pos, Quaternion.identity) as GameObject;
            newdef.transform.parent = DefenderParent.transform;
        }
        else
        {
            Debug.Log("Insufficient Stars to Spwan");
        }
    }
    Vector2 snaptogrid(Vector2 rawWorldPos)
    {
        float newx = Mathf.RoundToInt(rawWorldPos.x);
        float newy = Mathf.RoundToInt(rawWorldPos.y);

        return new Vector2(newx, newy);
    }

    Vector2 CalculationOfMouseClick()
    {
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;
        float distanceFromCamera = 10f;
        Vector3 weiredTriplet = new Vector3(mouseX, mouseY, distanceFromCamera);
        Vector2 worldPos = myCamera.ScreenToWorldPoint(weiredTriplet);
        return worldPos;
    }
}
