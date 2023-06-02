using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public GameObject enemy;
    public GameObject chest;
    public List<PlayerFeatues> pl_chois = new List<PlayerFeatues>();
    public GameObject panel_choise_player;


    void Start()
    {
           
    }

    public void choise1()
    {
        Instantiate(pl_chois[0].prefPlayer, new Vector3(Random.Range(-18, 18), Random.Range(-8, 8), 0), transform.rotation);
        panel_choise_player.SetActive(false);
    }
    public void choise2()
    {
        Instantiate(pl_chois[1].prefPlayer, new Vector3(Random.Range(-18, 18), Random.Range(-8, 8), 0), transform.rotation);
        panel_choise_player.SetActive(false);
    }

    public void CreateRandomEnemy()
    {
            Vector3 point = new Vector3(Random.Range(-17, 17), Random.Range(-8, 8), 0) + transform.position;
            Instantiate(enemy, point, Quaternion.Euler(new Vector3(0f, 0f, 0f)));     
    }

    public void CreateRandomChest()
    {  
            Vector3 point = new Vector3(Random.Range(-17, 17), Random.Range(-8, 8), 0) + transform.position;
            Instantiate(chest, point, Quaternion.Euler(new Vector3(0f, 0f, 0f)));  
    }

    IEnumerator RandomChest()
    {
        while (true)
        {
            CreateRandomChest();
            yield return new WaitForSeconds(4);
        }
    }

    IEnumerator RandomEmemy()
    {
        while (true)
        {
            CreateRandomEnemy();
            yield return new WaitForSeconds(4);
        }
    }






}
