using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public float health;
    public float maxHealth;


    public GameObject healthBarUI;
    public Slider slider;

    public GameObject gameOverButton;
    public GameObject gameOverText;

    private void Start()
    {
        healthBarUI = GameObject.FindGameObjectWithTag("Health");
        slider = GameObject.FindGameObjectWithTag("Health").GetComponent<Slider>();
        health = maxHealth;
        slider.value = CalculateHealth();
        //gameOver = GameObject.Find("Game Over");
    }

    private void Update()
    {
        //gameOver = GameObject.Find("Game Over");
        slider.value = CalculateHealth();

        if (health < maxHealth)
        {
            healthBarUI.SetActive(true);
        }
        else
        {
            healthBarUI.SetActive(false);
        }

        if (health <= 0)
        {
            //Destroy(gameObject);
            gameOverButton.SetActive(true);
            gameOverText.SetActive(true);
            Time.timeScale = 0;
        }

        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    float CalculateHealth()
    {
        return health / maxHealth;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Boss")
        {
            health -= 5;
        }
    }
}