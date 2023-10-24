using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public int moneyToGive;

    public void Pressed()
    {
        moneyToGive++;
    }
}
