using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeXP : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int randomXP = Random.Range(30, 60);
        if (collision.tag == "Player")
        {
            if (randomXP >= (PlayerUI.plUI.xp_slider.maxValue - PlayerUI.plUI.xp_slider.value))
            {
                PlayerController.instance.plF.xp = 0;
                PlayerController.instance.plF.maxXp += 50;
                PlayerController.instance.plF.levelHero += 1;
                PlayerController.instance.plF.skillPoint += 1;

            }
            else
            {
                PlayerController.instance.plF.xp += randomXP;
            }
            Destroy(gameObject);
        }
    }
}
