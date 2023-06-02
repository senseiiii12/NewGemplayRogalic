using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSkills : MonoBehaviour
{
    public static LevelSkills lvlskill;
    public GameObject levelSkillPanel;
    public Slider sliderAS;
    public Slider sliderMS;
    public Slider sliderD;
    public Slider sliderMH;

    public int plus_skillAS;
    public int plus_skillMS;
    public int plus_skillD;
    public int plus_skillMH;
    

    
    void Start()
    {
        lvlskill = this;    
    }
    void Update()
    {
        sliderAS.value = PlayerController.instance.plF.countAS;
        sliderMS.value = PlayerController.instance.plF.countMS;
        sliderD.value = PlayerController.instance.plF.countD;
        sliderMH.value = PlayerController.instance.plF.countMH;
    }

    public void UpSkillAS()
    {
        if (PlayerController.instance.plF.skillPoint > 0)
        {
            if (PlayerController.instance.plF.countAS < 10)
            {
                PlayerUI.plUI.plus_AS.SetActive(true);
                PlayerController.instance.plF.countAS++;
                plus_skillAS++;
                PlayerController.instance.plF.attackSpeed += 1;
                PlayerController.instance.plF.skillPoint--;
            }
        }           
    }
    public void UpSkillMS()
    {      
        if (PlayerController.instance.plF.skillPoint > 0)
        {
            if (PlayerController.instance.plF.countMS < 10)
            {
                PlayerUI.plUI.plus_MS.SetActive(true);
                PlayerController.instance.plF.countMS++;
                plus_skillMS++;
                PlayerController.instance.plF.moveSpeed += 1;
                PlayerController.instance.plF.skillPoint--;
            }
        }
    }
    public void UpSkillD()
    {    
        if (PlayerController.instance.plF.skillPoint > 0)
        {
            if (PlayerController.instance.plF.countD < 10)
            {
                PlayerUI.plUI.plus_D.SetActive(true);
                PlayerController.instance.plF.countD++;
                plus_skillD += 10;
                PlayerController.instance.plF.maxDamage += 10;
                PlayerController.instance.plF.skillPoint--;
            }
        }
    }
    public void UpSkillMH()
    {   
        if (PlayerController.instance.plF.skillPoint > 0)
        {
            if (PlayerController.instance.plF.countMH < 10)
            {
                PlayerUI.plUI.plus_MH.SetActive(true);
                PlayerController.instance.plF.countMH++;
                plus_skillMH += 25;
                PlayerController.instance.plF.maxHp += 25;
                PlayerUI.plUI.hp_slider.maxValue = PlayerController.instance.plF.maxHp;
                PlayerController.instance.plF.skillPoint--;
            }
        }
    }




}
