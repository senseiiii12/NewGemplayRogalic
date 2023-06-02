using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSkll_system : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            LevelSkills.lvlskill.levelSkillPanel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            LevelSkills.lvlskill.levelSkillPanel.SetActive(false);
        }
    }
}
