using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2.5f;
    
    Transform player;
    Rigidbody2D rb;
    EnemyLook boss;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = gameObject.GetComponent<Rigidbody2D>();
        boss = gameObject.GetComponent<EnemyLook>();
    }

    // Update is called once per frame
    void Update()
    {
       boss.LookAtPlayer();


        Vector2 target = new Vector2(player.position.x, player.position.y);
        Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
        
        if(Vector2.Distance(player.position, rb.position) <= 10)
        {
            rb.MovePosition(newPos);
        }
        
    }
}
