using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillRealiz : MonoBehaviour
{
    public int numberSkill;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScriptEnemy enemy = collision.GetComponent<ScriptEnemy>();
        bossScript boss = collision.GetComponent<bossScript>();
        bossScript_2 boss_2 = collision.GetComponent<bossScript_2>();
        if ((enemy != null) && numberSkill == 2)
        {
            enemy.TakeDamage(D_SpellController.d_instance.skillItems[numberSkill].damageSkill);
            Destroy(gameObject, 10);
        }
        else if ((collision.tag == "Boss") && numberSkill == 2)
        {
            boss.TakeDamage(D_SpellController.d_instance.skillItems[numberSkill].damageSkill);
            Destroy(gameObject, 10);
        }
        else if ((collision.tag == "Boss") && numberSkill == 2) 
        {
            boss_2.TakeDamage(D_SpellController.d_instance.skillItems[numberSkill].damageSkill);
            Destroy(gameObject, 10);
        }
        
        if(enemy != null)
        {
            enemy.TakeDamage(D_SpellController.d_instance.skillItems[numberSkill].damageSkill);
            Destroy(gameObject);
        }
        else if (collision.tag == "Boss")
        {
            boss.TakeDamage(D_SpellController.d_instance.skillItems[numberSkill].damageSkill);
            Destroy(gameObject);
        }
        else
        {
            boss_2.TakeDamage(D_SpellController.d_instance.skillItems[numberSkill].damageSkill);
            Destroy(gameObject);
        }
        
    }
}
