using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public GameObject shopPanel;
    public Button inventoryUppgrade;
    public Text inventoryUppgradeText;
    public Button speedUppgrade;
    public Text speedUppgradeText;

    void Start()
    {
        inventoryUppgrade.GetComponent<Button>().onClick.AddListener(OnInventoryUppgradeClick);
        speedUppgrade.GetComponent<Button>().onClick.AddListener(OnSpeedUppgradeClick);
    }

    void Update()
    {
        if (ShopArea.isShop)
        {
            shopPanel.SetActive(true);
        }
        else
        {
            shopPanel.SetActive(false);
        }
    }

    void OnInventoryUppgradeClick()
    {
        if (Stats.waterAmount >= Uppgrades.waterStorageCost)
        {
            Stats.waterAmount -= Uppgrades.waterStorageCost;
            Uppgrades.waterStorageCost *= 2;
            inventoryUppgradeText.text = "Uppgrade Inventory: " + Uppgrades.waterStorageCost + "         ";
            Uppgrades.waterStorage *= 2;
        }
    }
    void OnSpeedUppgradeClick()
    {
        if (Stats.waterAmount >= Uppgrades.speedMultiplierCost)
        {
            Stats.waterAmount -= Uppgrades.speedMultiplierCost;
            Uppgrades.speedMultiplierCost *= 10;
            speedUppgradeText.text = "Uppgrade Speed: " + Uppgrades.speedMultiplierCost + "    ";
            Uppgrades.speedMultiplier += 1;
        }
    }
}
