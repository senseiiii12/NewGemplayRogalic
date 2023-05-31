using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSkll_system : MonoBehaviour
{

    public GameObject levelSkillPanel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            levelSkillPanel.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            levelSkillPanel.SetActive(false);
        }
    }
}
