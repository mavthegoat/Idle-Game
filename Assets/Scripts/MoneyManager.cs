using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public int balance;
    public TextMeshProUGUI moneytext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moneytext.text = "Money:" + balance;
    }

    public void AddMoney()
    {
        balance++;
    }
}
