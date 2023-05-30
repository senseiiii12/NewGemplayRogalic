using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillRealiz : MonoBehaviour
{
    public int numberSkill;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScriptEnemy enemy = collision.GetComponent<ScriptEnemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(D_SpellController.d_instance.skillItems[numberSkill].damageSkill);
            Destroy(gameObject); 
        }
    }
}
