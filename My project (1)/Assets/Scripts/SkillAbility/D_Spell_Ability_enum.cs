using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Spell", menuName = "Spell/Create new Spell")]
public class D_Spell_Ability_enum : ScriptableObject
{
    public int id;
    public int ManaCoastSkill;
    public int damageSkill;
    public float forceSkill;
    public float kd;
    public bool IsCoolDown;
    public Sprite iconSkill;
    public SkillsType typeSkill;
    public GameObject prefabSkill;

    public enum SkillsType
    {
        DamageSkill,
        HealSkill
    }

    
}
