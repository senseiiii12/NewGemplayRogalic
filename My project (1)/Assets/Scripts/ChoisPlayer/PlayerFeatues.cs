using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Player", menuName = "Player/Create new Player")]
public class PlayerFeatues : ScriptableObject
{
    public int hp;
    public int maxHp;
    public int xp;
    public int maxXp;
    public int mana;
    public int maxMana;
    public int maxDamage;
    public int moveSpeed;
    public int attackSpeed;
    public int manaRegen;
    public int manaCoast;
    public int killCount;
    public int skillPoint;
    public int levelHero;

    public Sprite skin;
    public GameObject prefPlayer;
    public GameObject prefBullet;


    public int bitCoins;
    public int souls;
    public int keys;

    public int countAS;
    public int countMS;
    public int countD;
    public int countMH;

   
    
   
}
