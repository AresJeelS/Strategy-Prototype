using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingButton : MonoBehaviour
{
    public BuildingPlacer BuildingPlacer;
    public GameObject BuildingPrefab;

    public void TryBuy()
    {
        int price = BuildingPrefab.GetComponent<Building>().Price;
        if (FindObjectOfType<Resource>().Money >= price)
        {
            FindObjectOfType<Resource>().Money -= price;
            BuildingPlacer.CreateBuilding(BuildingPrefab);
        }
        else
        {
            Debug.Log("Мало денег!");
        }
    }
}
