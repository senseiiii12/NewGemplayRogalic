using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/Create new Item")]
public class Item : ScriptableObject
{
    public int id;
    public string itemName;
    public int price;
    public int value;
    public Sprite icon;
    public ItemType type;
    public GameObject prefab;
    public enum ItemType
    {
        PotionHeal,
        PotionMana,
        Weapon,
        OverSpeed
    }

   

}
