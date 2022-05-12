using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManController : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    private const float JUMP_AMOUNT = 5;
    public GameObject bullet;
    Vector2 bulletPos;
    public float fireRate = 0.5f;
    float nextFire = 0.0f;
    public GameObject sound;
    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(0))
        {
            nextFire = Time.time + fireRate;
            Fire();
            Jump();
        }
    }
    private void Jump()
    {
        rigidbody2D.velocity = Vector2.up * JUMP_AMOUNT;
    }
   
    void Fire()
    {
        bulletPos = transform.position;
        bulletPos += new Vector2(+0.5f, 0.33f);
        Instantiate(bullet, bulletPos, Quaternion.identity);
        Instantiate(sound, transform.position, Quaternion.identity);
    }
    
}
