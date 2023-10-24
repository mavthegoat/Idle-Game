using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    public GameObject[] buildings;
    int activeBuildings = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void purchasebuilding()
    {
        buildings[activeBuildings].SetActive(true);
        activeBuildings++;
        if (activeBuildings >= buildings.Length)
        {
            Debug.Log("Buildings complete");
        }
    }
}
