using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFieldBoss : MonoBehaviour
{
    int speed = PlayerController.instance.plF.moveSpeed;
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.tag == "Player")
        {
            PlayerController.instance.plF.moveSpeed = 5;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PlayerController.instance.plF.moveSpeed = speed;
        }
    }
}
