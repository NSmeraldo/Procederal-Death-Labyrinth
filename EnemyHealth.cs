using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;

    public GameObject healthPotion;

    public GameObject healthBarUI;
    public Slider slider;

    public GameObject difficultyManager;
    public GameObject expManager;

    DifficultyManager difficultyNumber;
    EXPmanager level;

    public GameObject endGoal;

    private void Start()
    {
        difficultyManager = GameObject.FindGameObjectWithTag("DifficultyManager");
        expManager = GameObject.FindGameObjectWithTag("EXPManager");

        difficultyNumber = difficultyManager.GetComponent<DifficultyManager>();
        level = expManager.GetComponent<EXPmanager>();


        maxHealth = 95 + 20 * difficultyNumber.difficulty + 5 *level.Level;
        health = maxHealth;
        slider.value = CalculateHealth();

    }

    private void Update()
    {
        slider.value = CalculateHealth();

        

        if (health < maxHealth)
        {
            healthBarUI.SetActive(true);
        }
        else
        {
            healthBarUI.SetActive(false);
        }

        if(health <= 0)
        {
            if (gameObject.tag == "Boss")
            {
                Instantiate(endGoal, transform.position, Quaternion.identity);
            }
            level.exp += 10;
            int drop = Random.Range(0, 10);
            if(drop > 6)
            {
               Instantiate(healthPotion, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }

        if(health > maxHealth)
        {
            health = maxHealth;
        }
    }

    float CalculateHealth() 
    {
        return health / maxHealth;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            health -= 10 + (-1 + level.Level) * 2;
        }
    }
}
