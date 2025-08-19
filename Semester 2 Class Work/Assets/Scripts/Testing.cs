using UnityEngine;
using myGame.characters;

public class Testing : MonoBehaviour
{
    public Hero hero;
    public Enemy enemy;

    public PotionData potionData;

    public InventoryItem inventoryItem;

    void Start()
    {
        hero.PrintHealth();
        enemy.PrintDamage();

        print("Potion Name: " + potionData.potionName);
        print("Health Restored: " + potionData.healthRestored);

        print("Inventory Item Name: " + inventoryItem.name);
        print("Item Description: " + inventoryItem.itemDescription);
        print("Item Value: " + inventoryItem.value);
    }
}
