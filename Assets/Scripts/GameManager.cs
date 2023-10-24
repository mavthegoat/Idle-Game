using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int money;
    public Text MoneyDisplay;

    private Building buildingToPlace;
    public GameObject grid;

    public CustomCursor customCursor;
 
    private void Update()
    {
        MoneyDisplay.text = money.ToString();
    }

   public void BUuyBuilding(Building building)
    {
        if (money >= building.cost)
        {
            customCursor.gameObject.SetActive(true);
            customCursor.GetComponent<SpriteRenderer>().sprite = building.GetComponent<SpriteRenderer>().sprite;
            Cursor.visible = false;
            money -= building.cost;
            buildingToPlace = building;
            grid.SetActive(true);
        }
    }
}
