using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bossScript_2 : MonoBehaviour
{
    public int health;
    public int sheild;
    public GameObject prefbullet;
    GameObject player;
    public float force;
    public float cooldown;
    public GameObject XP;
    public GameObject portal;
    public GameObject bullet360;


    public int minDamage;
    public int maxDamage;

    public GameObject canvasHp;
    public Slider hBarEnemySlider;
    public GameObject canvasSheild;
    public Slider sheildbar;
    bool isSheild = false;

    int[] mass_X = { -15, 15 };
    int[] mass_Y = { -10, 10 };

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
    }

    public void TakeDamage(int damage)
    {
        if (health < 2000 && sheild > 0)
        {
            isSheild = true;
            canvasSheild.SetActive(true);
            bullet_360();
        }
        else
        {
            isSheild = false;
        }

        if (sheildbar.isActiveAndEnabled)
        {
            sheild -= damage;
            if (!isSheild)
            {
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
        int rand_i = Random.Range(0, 2);
        PlayerController.instance.plF.killCount += 1;
        CreateXP();
        Instantiate(portal, transform.position + new Vector3(mass_X[rand_i], mass_Y[rand_i], 0), Quaternion.identity);
        Destroy(gameObject);
    }

    void enemyShooting()
    {
        Vector2 mPosition = player.GetComponent<Transform>().position;
        Vector2 myPosition = transform.position;
        if (Vector2.Distance(mPosition, myPosition) < 20)
        {
            GameObject spell = Instantiate(prefbullet, transform.position, Quaternion.identity);
            Vector2 direction = mPosition - myPosition;
            spell.GetComponent<Rigidbody2D>().velocity = direction * force;
            Destroy(spell, 8);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int damage = Random.Range(minDamage, maxDamage);
        PlayerController player = collision.GetComponent<PlayerController>();
        if (player != null)
        {
            PlayerController.instance.getDamage(damage);
        }
    }

    public void CreateXP()
    {
        int random = Random.Range(20, 30);
        for (int i = 0; i < random; i++)
        {
            Vector3 point = (Random.insideUnitSphere * 2) + transform.position;
            Instantiate(XP, point, Quaternion.Euler(new Vector3(0f, 0f, 0f)));
        }
    }

    public void bullet_360()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject spawnedObject = Instantiate(bullet360, transform.position, Quaternion.identity);
            Vector2 randomDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
            spawnedObject.GetComponent<Rigidbody2D>().velocity = randomDirection * 7;
            Destroy(spawnedObject, 8);
        }
    }
}
