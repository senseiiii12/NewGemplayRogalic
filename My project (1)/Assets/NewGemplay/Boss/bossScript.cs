using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bossScript : MonoBehaviour
{
    
    public int health;
    public int sheild;
    public GameObject prefbullet;
    GameObject player;
    public float force;
    public float cooldown;
    public GameObject XP;

    public int minDamage;
    public int maxDamage;

    public GameObject canvasHp;
    public Slider hBarEnemySlider;
    public GameObject canvasSheild;
    public Slider sheildbar;



    void Start()
    {
        hBarEnemySlider.maxValue = health;
        sheildbar.maxValue = sheild;
        InvokeRepeating("enemyShooting", cooldown, cooldown);
    }


    void Update()
    {
        hBarEnemySlider.value = health;
        sheildbar.value = sheild;
        player = GameObject.FindGameObjectWithTag("Player");

        if (health < health * 0.75)
        {
            canvasSheild.SetActive(true);
        }


    }
    public void TakeDamage(int damage)
    {
        canvasHp.SetActive(true);

        if(sheildbar.IsActive()){
            sheild -= damage; 
            if(sheild <= 0) {
                canvasSheild.SetActive(false);
            }
        }
        else
        {
            health -= damage;
            if (health <= 0)
            {
                Die();
            }
        }
        
    }

    private void Die()
    {
        PlayerController.instance.plF.killCount += 1;
        CreateXP();
        Destroy(gameObject);
    }

    void enemyShooting()
    {
        GameObject spell = Instantiate(prefbullet, transform.position, Quaternion.identity);
        Vector2 mPosition = player.GetComponent<Transform>().position;
        Vector2 myPosition = transform.position;
        Vector2 direction = mPosition - myPosition;
        if (Vector2.Distance(mPosition, myPosition) < 25)
        {
            spell.GetComponent<Rigidbody2D>().velocity = direction * force;
            Destroy(spell, 3);
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int damage = Random.Range(minDamage, maxDamage);
        PlayerMove player = collision.GetComponent<PlayerMove>();
        if (player != null)
        {
            PlayerController.instance.getDamage(damage);
        }
    }


    public void CreateXP()
    {
        int random = Random.Range(10, 30);
        for (int i = 0; i < random; i++)
        {
            Vector3 point = (Random.insideUnitSphere * 2) + transform.position;
            Instantiate(XP, point, Quaternion.Euler(new Vector3(0f, 0f, 0f)));
        }
    }
}
