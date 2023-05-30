using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitCoin: MonoBehaviour
{
    public int denomination;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag == "Player")
        {
            PlayerController.instance.plF.bitCoins += denomination;
            Destroy(gameObject);
        }
    }
} 
