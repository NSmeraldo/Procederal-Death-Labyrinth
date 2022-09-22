using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject Player;
    //public GameObject enemy;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        //enemy = GameObject.FindGameObjectWithTag("Enemy");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag != Player.tag)
        {
            Destroy(collision.gameObject);
        }
        
    }
}
