using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class D_SpellController : MonoBehaviour
{
    public static D_SpellController d_instance;
    public List<D_Spell_Ability_enum> skillItems = new List<D_Spell_Ability_enum>();
    public Transform SkillContent;
    public GameObject SkillItem;
    public GameObject obj;


    private void Start()
    {
        d_instance = this;
        ListSkill();
    }

    public void ListSkill()
    {
        foreach (D_Spell_Ability_enum itemSkill in skillItems)
        {
            obj = Instantiate(SkillItem, SkillContent);
            Image skillIcon = obj.transform.Find("ImageSkill").GetComponent<Image>();
            skillIcon.sprite = itemSkill.iconSkill;
        }
    }
  
}
