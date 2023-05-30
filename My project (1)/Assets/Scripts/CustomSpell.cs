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
        int damage = Random.Range(0, PlayerController.instance.plF.maxDamage);
        ScriptEnemy enemy = collision.GetComponent<ScriptEnemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
       
    }
}
