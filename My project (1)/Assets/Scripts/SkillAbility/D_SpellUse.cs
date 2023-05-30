using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class D_SpellUse : MonoBehaviour
{
    GameObject player;
    int kd;
    Image skillIcon;
    
    

    private void Start()
    {   
        player = GameObject.FindGameObjectWithTag("Player");
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
    }

    private void FixedUpdate()
    {

        //CoolDown(kd);

    }


    public void UseSkill(int i)
    {
        if(PlayerController.instance.plF.mana > 0 /*&& D_SpellController.d_instance.skillItems[i].IsCoolDown == false*/)
        {
            PlayerController.instance.plF.mana -= D_SpellController.d_instance.skillItems[i].ManaCoastSkill;
            GameObject spell = Instantiate(D_SpellController.d_instance.skillItems[i].prefabSkill, player.transform.position, Quaternion.identity);
            Vector2 mPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 myPosition = player.transform.position;
            Vector2 direction = mPosition - myPosition;
            spell.GetComponent<Rigidbody2D>().velocity = direction * D_SpellController.d_instance.skillItems[i].forceSkill;
            Destroy(spell, 2);

            //D_SpellController.d_instance.skillItems[i].IsCoolDown = true;

            //skillIcon = D_SpellController.d_instance.obj.transform.Find("ImageSkill").GetComponent<Image>();
            //skillIcon.sprite = D_SpellController.d_instance.skillItems[i].iconSkill;
            //skillIcon.fillAmount = 0;

            kd = i;
            
        }   
    }
    
    public void CoolDown(int i)
    {
        if (D_SpellController.d_instance.skillItems[i].IsCoolDown == true)
        {
            skillIcon.fillAmount += 1 / D_SpellController.d_instance.skillItems[i].kd * Time.deltaTime;
            if (skillIcon.fillAmount == 1)
            {
                D_SpellController.d_instance.skillItems[i].IsCoolDown = false;
            }
        }
    }
}
