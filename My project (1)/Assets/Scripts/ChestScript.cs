using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    Animator animator;
    bool isOpen = false;
    public float spawnradius;
    public GameObject agent_coin;
    public GameObject agent_heal;
    public GameObject agent_mana;
    public GameObject agent_key;
   
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
       
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && PlayerController.instance.plF.keys > 0 && isOpen == false)
        {
            isOpen = true;
            animator.SetBool("isOpen", true);
            PlayerController.instance.plF.keys -= 1;
            CreateAgent();
            Destroy(gameObject, 4);
        }

        
    }
    public void CreateAgent()
    {
        int r1= Random.Range(0, 101);
        Debug.Log(r1);

        for (int i = 0; i < 5; i++)
        {

            Vector3 point = (Random.insideUnitSphere * spawnradius) + transform.position;


            if (r1 <= 5 && i == 4)
            {
                Instantiate(agent_key, point, Quaternion.Euler(new Vector3(0f, 0f, 0f)));
            }
            else
            {
                Instantiate(agent_coin, point, Quaternion.Euler(new Vector3(0f, 0f, 0f)));
            }          
            
        }
    }
}
