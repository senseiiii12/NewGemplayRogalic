using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    private Rooms templates;
    
    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<Rooms>();
        templates.rooms.Add(this.gameObject);
    }

    
}
