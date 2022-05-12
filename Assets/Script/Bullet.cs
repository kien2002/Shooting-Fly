using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public float velX = 5f;
    float velY = 0f;
    Rigidbody2D rb;
    private Text score;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
       
        rb.velocity = new Vector2(velX, velY);
        Destroy(gameObject, 2f);
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("box"))
        {
            DeathZone.instance.AddPoint();
            Destroy(collision.gameObject);      
        }
    }
}
