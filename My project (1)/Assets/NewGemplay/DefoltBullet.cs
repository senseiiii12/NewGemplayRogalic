using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefoltBullet : MonoBehaviour
{

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && PlayerController.instance.plF.mana > 0)
        {
            PlayerController.instance.plF.mana -= PlayerController.instance.plF.manaCoast;
            Debug.Log(PlayerController.instance.plF.mana);
            GameObject spell = Instantiate(PlayerController.instance.plF.prefBullet, transform.position, Quaternion.identity);
            Vector2 mPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 myPosition = transform.position;
            Vector2 direction = mPosition - myPosition;
            spell.GetComponent<Rigidbody2D>().velocity = direction * PlayerController.instance.plF.attackSpeed;
            Destroy(spell, 2);
        }
    }
}
