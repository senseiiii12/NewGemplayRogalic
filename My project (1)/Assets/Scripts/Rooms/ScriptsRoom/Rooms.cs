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

    public List<GameObject> rooms;

    
    private void Start()
    {
        Invoke("spawnBoss", 5);
    }
    

    public void spawnBoss()
    {
        int rand = Random.Range(0, rooms.Count);
        Instantiate(prefBoss, rooms[rand].transform.position, Quaternion.identity);
    }
}
