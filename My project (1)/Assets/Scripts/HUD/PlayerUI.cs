using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public static PlayerUI plUI;

    public Slider hp_slider;
    public Slider mana_slider;
    public Slider xp_slider;

    public Image iconPlayer;


    public GameObject countCoin;
    public GameObject countSouls;
    public GameObject countKeys;

    public GameObject attackSpeed;
    public GameObject moveSpeed;
    public GameObject damage;
    public GameObject maxHealth;
    public GameObject killCount;
    public GameObject CountLevel;
    public GameObject CountSkillPoint;

    public GameObject CountInSliderAS;
    public GameObject CountInSliderMS;
    public GameObject CountInSliderD;
    public GameObject CountInSliderMH;

    public GameObject plus_AS;
    public GameObject plus_MS;
    public GameObject plus_D;
    public GameObject plus_MH;

    public GameObject HP_text;
    public GameObject Mana_text;


    // Start is called before the first frame update
    void Start()
    {
        plUI = this;
        
    }

    // Update is called once per frame
    void Update()
    {
        countCoin.GetComponent<Text>().text = PlayerController.instance.plF.bitCoins.ToString();
        countSouls.GetComponent<Text>().text = PlayerController.instance.plF.souls.ToString();
        countKeys.GetComponent<Text>().text = PlayerController.instance.plF.keys.ToString();


        attackSpeed.GetComponent<Text>().text = PlayerController.instance.plF.attackSpeed.ToString();
        moveSpeed.GetComponent<Text>().text = PlayerController.instance.plF.moveSpeed.ToString();
        damage.GetComponent<Text>().text = PlayerController.instance.plF.maxDamage.ToString();
        maxHealth.GetComponent<Text>().text = PlayerController.instance.plF.maxHp.ToString();
        
        killCount.GetComponent<Text>().text = PlayerController.instance.plF.killCount.ToString();
        CountLevel.GetComponent<Text>().text = PlayerController.instance.plF.levelHero.ToString();
        CountSkillPoint.GetComponent<Text>().text = PlayerController.instance.plF.skillPoint.ToString();

        CountInSliderAS.GetComponent<Text>().text = PlayerController.instance.plF.countAS.ToString();
        CountInSliderMS.GetComponent<Text>().text = PlayerController.instance.plF.countMS.ToString();
        CountInSliderD.GetComponent<Text>().text = PlayerController.instance.plF.countD.ToString();
        CountInSliderMH.GetComponent<Text>().text = PlayerController.instance.plF.countMH.ToString();

        plus_AS.GetComponent<Text>().text = "+" + LevelSkills.lvlskill.plus_skillAS.ToString();
        plus_MS.GetComponent<Text>().text = "+" + LevelSkills.lvlskill.plus_skillMS.ToString();
        plus_D.GetComponent<Text>().text = "+" + LevelSkills.lvlskill.plus_skillD.ToString();
        plus_MH.GetComponent<Text>().text = "+" + LevelSkills.lvlskill.plus_skillMH.ToString();

        HP_text.GetComponent<Text>().text = PlayerController.instance.plF.hp.ToString();
        Mana_text.GetComponent<Text>().text = PlayerController.instance.plF.mana.ToString();





    }
}
