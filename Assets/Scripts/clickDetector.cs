using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class clickDetector : MonoBehaviour
{
    public SpriteRenderer buttonunpressed;
    public SpriteRenderer buttonpressed;
    public bool canclick;
    public float unpresstime;

    void Start()
    {
        canclick = true;
    }

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && canclick)
        {
            Debug.Log("has Clicked");
            canclick = false;
            buttonpressed.enabled = true;
            buttonunpressed.enabled = false;
            StartCoroutine(WaitToBeUnpressed());
        }
    }

    public void OnMouseExit()
    {
        
    }

    IEnumerator WaitToBeUnpressed() 
    {
        yield return new WaitForSeconds(unpresstime);
        buttonunpressed.enabled = true;
        buttonpressed.enabled = false;
        canclick = true;
    }
}
