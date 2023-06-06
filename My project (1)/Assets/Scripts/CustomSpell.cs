using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomSpell : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int damage = Random.Range(PlayerController.instance.plF.maxDamage - (PlayerController.instance.plF.maxDamage / 2), PlayerController.instance.plF.maxDamage);
        ScriptEnemy enemy = collision.GetComponent<ScriptEnemy>();
        bossScript boss = collision.GetComponent<bossScript>();
        bossScript_2 boss_2 = collision.GetComponent<bossScript_2>();
        if (collision.tag == "Enemy")
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
        else if(collision.tag == "Boss") {
            boss.TakeDamage(damage);
            Destroy(gameObject);
        }
        else if (collision.tag == "Boss 2")
        {
            boss_2.TakeDamage(damage);
            Destroy(gameObject);
        }


    }
}
