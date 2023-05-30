using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{
    public static ShopController ShopInstance;
    public List<Item> items = new List<Item>();
    public Transform ItemContent;
    public GameObject shopItem;
    //public ItemController[] inventoryItems;
    

    public void ListItems()
    {
        foreach (Item item in items)
        {
            GameObject obj = Instantiate(shopItem, ItemContent);
            var itemName = obj.transform.Find("TextItem").GetComponent<Text>();
            var itemIcon = obj.transform.Find("ImageItem").GetComponent<Image>();
            var itemprice = obj.transform.Find("PriceItem").GetComponent<Text>();
            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;
            itemprice.text = item.price.ToString();
            obj.GetComponent<ItemController>().item = item;
        }    
    }

   
    public void clear()
    {
        foreach (Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }
    }

    public void Start()
    {
        ShopInstance = this;
    }




}
