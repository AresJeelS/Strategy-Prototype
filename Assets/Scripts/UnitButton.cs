using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UnitButton : MonoBehaviour
{
    public GameObject UnitPrefab;
    public TextMeshProUGUI PriceText;
    public Barack Barack;

    private void Start()
    {
        PriceText.text = UnitPrefab.GetComponent<Unit>().Price.ToString();
    }
    public void TryBuy()
    {
        int price = UnitPrefab.GetComponent<Unit>().Price;
        if (FindObjectOfType<Resource>().Money >= price)
        {
            FindObjectOfType<Resource>().Money -= price;
            Barack.CreateUnit(UnitPrefab);
        }
        else
        {
            Debug.Log("Мало денег!");
        }
    }
}
