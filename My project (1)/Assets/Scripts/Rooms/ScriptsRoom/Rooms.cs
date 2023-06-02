using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooms : MonoBehaviour
{
    
    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;

    public GameObject closedRoom;

    public GameObject prefBoss;
    public GameObject enemy;
    public GameObject chest;
    public GameObject shop;
    public GameObject fire;

    public List<GameObject> rooms;

    private void Start()
    {


        Invoke("spawnBoss", 5);
        Invoke("spawnEnemy", 10);
        Invoke("spawnShop", 12);
        Invoke("spawnFire", 15);


    }
    

    public void spawnBoss()
    {
        int rand = Random.Range(0, rooms.Count);
        Instantiate(prefBoss, rooms[rand].transform.position, Quaternion.identity);
    }

    public void spawnEnemy()
    {
        for (int i = 0; i < rooms.Count; i++)
        {
            int rand = Random.Range(0, 5);
            for (int j = 0; j < rand; j++)
            {
                Instantiate(enemy, rooms[i].transform.position + new Vector3(Random.Range(-18,18),Random.Range(-8,8),0), Quaternion.identity);
                Instantiate(chest, rooms[i].transform.position + new Vector3(Random.Range(-18,18),Random.Range(-8,8),0), Quaternion.identity);
            }
        }


    }

    public void spawnShop()
    {
        float countShop = rooms.Count / 2;
        for (int i = 0; i < countShop; i++)
        {
            int rand = Random.Range(0, rooms.Count);
            Instantiate(shop, rooms[rand].transform.position + new Vector3(Random.Range(-18, 18), Random.Range(-8, 8), 0), Quaternion.identity);
        }
    }

    public void spawnFire()
    {
        int rand_itr = Random.Range(1, 5);
        for (int i = 0; i < rand_itr ; i++)
        {
            int rand_rooms = Random.Range(3, rooms.Count);
            int rand_x = Random.Range(-16,16);
            int rand_y = Random.Range(-8,8);
            Instantiate(fire, rooms[rand_rooms].transform.position + new Vector3(rand_x, rand_y, 0), Quaternion.identity);
        }
    }



}
