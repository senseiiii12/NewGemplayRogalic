using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShop : MonoBehaviour
{
    public GameObject shopPanel;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ShopController.ShopInstance.panelShop.SetActive(true);
            ShopController.ShopInstance.ListItems();
            
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ShopController.ShopInstance.panelShop.SetActive(false);
            ShopController.ShopInstance.clear();
 
        }
    }
}
