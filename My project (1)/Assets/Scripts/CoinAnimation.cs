using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAnimation : MonoBehaviour
{
    public float speed;
    public double animationDuration = 2f; 
    private Vector3 direction;
    private float timer;
    private bool isAnimating = true;

    private void Start()
    {
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f).normalized;
    }

    private void Update()
    {
        if (isAnimating)
        { 
            transform.Translate(direction * speed * Time.deltaTime);
            timer += Time.deltaTime;
            if (timer >= animationDuration)
            {
                isAnimating = false;
            }
        }
    }
}
