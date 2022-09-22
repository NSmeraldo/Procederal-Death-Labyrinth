using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthpotion : MonoBehaviour
{
    public GameObject healthManager;
    HealthManager health;

    private void Start()
    {
        healthManager = GameObject.FindGameObjectWithTag("Health");
        health = healthManager.GetComponent<HealthManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            health.health += 5;
            Destroy(gameObject);
        }
    }
}
