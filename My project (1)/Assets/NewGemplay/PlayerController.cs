using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    public PlayerFeatues plF;
    float horizontal;
    float vertical;
    Vector2 direction;
    Animator animator;
    new Rigidbody2D rigidbody2D;

    public GameObject player;
    



    // Start is called before the first frame update
    void Start()
    {
        
        instance = this;
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();


        plF.moveSpeed = plF.countMS + 10;
        PlayerUI.plUI.iconPlayer.sprite = plF.skin;
        PlayerUI.plUI.hp_slider.maxValue = plF.maxHp;
        PlayerUI.plUI.xp_slider.maxValue = plF.maxXp;
        plF.hp = plF.maxHp;

        StartCoroutine(getMMana(30));
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");


        PlayerUI.plUI.xp_slider.value = plF.xp;
        PlayerUI.plUI.hp_slider.value = plF.hp;
        PlayerUI.plUI.mana_slider.value = plF.mana;
        
    }
    private void FixedUpdate()
    {
        if (horizontal != 0 || vertical != 0)
        {
            AnimatorMovement(horizontal, vertical);
        }
        else
        {
            animator.SetLayerWeight(1, 0);
        }
        rigidbody2D.velocity = new Vector2(horizontal * plF.moveSpeed, vertical * plF.moveSpeed);
    }

    private void AnimatorMovement(float x, float y)
    {
        animator.SetLayerWeight(1, 1);
        animator.SetFloat("DirectionX", x);
        animator.SetFloat("DirectionY", y);
    }




    IEnumerator getMMana(int manaIteration)
    {

        while (true)
        {
            float razn = PlayerUI.plUI.mana_slider.maxValue - PlayerUI.plUI.mana_slider.value;
            if (manaIteration >= razn)
            {
                plF.mana += (int)razn;
                yield return null;
            }
            else
            {
                plF.mana += manaIteration;
            }
            yield return new WaitForSeconds(1);
        }
    }

    public void getDamage(int damage)
    {
        plF.hp -= damage;
        if (plF.hp <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        SceneManager.LoadScene(1);
    }
    public void getHeal(int heal)
    {
        plF.hp += heal;
        if (plF.hp > plF.maxHp)
        {
            plF.hp = plF.maxHp;
        }
    }
    public void getMana(int mana)
    {
        plF.mana += mana;
        if (mana > plF.maxMana)
        {
            mana = plF.maxMana;
        }
    }
}
