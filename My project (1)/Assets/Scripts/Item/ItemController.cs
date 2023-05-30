using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    public Item item;
    

    public void RemoveItem()
    {
        InventoryController.Instance.Remove(item);
        Destroy(gameObject);
    }
    public void AddItem(Item newItem)
    {
        item = newItem;
    }
    public void UseItem()
    {
        switch (item.type)
        {
            case Item.ItemType.PotionHeal:
                PlayerController.instance.getHeal(item.value);
                RemoveItem();
                break;
            case Item.ItemType.PotionMana:
                PlayerController.instance.getMana(item.value);
                RemoveItem();
                break;
            case Item.ItemType.Weapon:
                PlayerController.instance.plF.maxDamage += item.value;
                RemoveItem();
                break;
            case Item.ItemType.OverSpeed:
                PlayerController.instance.plF.moveSpeed += item.value;
                RemoveItem();
                break;
        }
    }

    public void ByItemShop()
    {
        if (PlayerController.instance.plF.bitCoins >= item.price)
        {
            PlayerController.instance.plF.bitCoins -= item.price;
            InventoryController.Instance.Add(item);
        }   
    }


    public void DropItem()
    {
            Vector3 point = (UnityEngine.Random.insideUnitSphere * 5) + PlayerController.instance.player.transform.position;
            Instantiate(item.prefab, point, Quaternion.Euler(new Vector3(0f, 0f, 0f)));
            InventoryController.Instance.Remove(item);
            Destroy(gameObject);
    }


   
}
