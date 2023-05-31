using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class D_SpellUse : MonoBehaviour
{
     GameObject player;
    private void Start()
    {
        

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            UseSkill(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            UseSkill(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            UseSkill(2);
        }

        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate()
    {
        CoolDown();
    }




    public void UseSkill(int i)
    {
        if(PlayerController.instance.plF.mana > 0 && D_SpellController.d_instance.skillItems[i].IsCoolDown == false)
        {


            D_SpellController.d_instance.skillImages[i].fillAmount = 0;
            D_SpellController.d_instance.skillItems[i].IsCoolDown = true;


            PlayerController.instance.plF.mana -= D_SpellController.d_instance.skillItems[i].ManaCoastSkill;

            GameObject spell = Instantiate(D_SpellController.d_instance.skillItems[i].prefabSkill, player.transform.position, Quaternion.identity);
            Vector2 mPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 myPosition = player.transform.position;
            Vector2 direction = mPosition - myPosition;
            spell.GetComponent<Rigidbody2D>().velocity = direction * D_SpellController.d_instance.skillItems[i].forceSkill;
            Destroy(spell, 2);

        }   
    }
    
    public void CoolDown()
    {
        for (int j = 0; j < D_SpellController.d_instance.skillItems.Count; j++)
        { 
            if (D_SpellController.d_instance.skillItems[j].IsCoolDown == true)
            {
                D_SpellController.d_instance.skillImages[j].fillAmount += 1 / D_SpellController.d_instance.skillItems[j].kd * Time.deltaTime;
                if (D_SpellController.d_instance.skillImages[j].fillAmount == 1)
                {
                    D_SpellController.d_instance.skillItems[j].IsCoolDown = false;
                }
            }
        }
    }


}
