using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class stardisplay : MonoBehaviour {

    private Text startText;
    private int stars = 100;
    public enum Status { SUCESS,FAILURE};
    void Start()
    {
        startText = GetComponent<Text>();
        UpdateDisplay();
    }
	public void Addstars(int amt)
    {
        stars = stars + amt;
        UpdateDisplay();
    }
    public Status UseStars(int amt)
    {
        if (stars >= amt)
        {
            stars -= amt;
            UpdateDisplay();
            return Status.SUCESS;
        }
        return Status.FAILURE;
        
    }
    private void UpdateDisplay()
    {
        startText.text = stars.ToString();
    }
}
