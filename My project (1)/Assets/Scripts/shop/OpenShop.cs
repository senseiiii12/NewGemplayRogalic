using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShop : MonoBehaviour
{
    public GameObject shopPanel;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            shopPanel.SetActive(true);
            ShopController.ShopInstance.ListItems();
            
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            shopPanel.SetActive(false);
            ShopController.ShopInstance.clear();
 
        }
    }
}
