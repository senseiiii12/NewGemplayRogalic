using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class EnemySpell : MonoBehaviour
{
    public int minDamage;
    public int maxDamage;
    PlayerController stats;
    

    
    void Update()
    {
        stats = GameObject.FindAnyObjectByType<PlayerController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int damage = Random.Range(minDamage, maxDamage);
        PlayerController player = collision.GetComponent<PlayerController>();
        if (player != null)
        {
            stats.getDamage(damage);
            Destroy(gameObject);
        }
    }
}
