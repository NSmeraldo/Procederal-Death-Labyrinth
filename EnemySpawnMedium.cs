using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnMedium : MonoBehaviour
{
    public GameObject[] Items;
    
    public GameObject difficultyManager;
    DifficultyManager difficultyNumber;

    private void Start()
    {
        difficultyManager = GameObject.FindGameObjectWithTag("DifficultyManager");
        difficultyNumber = difficultyManager.GetComponent<DifficultyManager>();

        if(difficultyNumber.difficulty >= 1 )
        {
            Instantiate(Items[Random.Range(0, Items.Length - 1)], transform.position, Quaternion.identity);
        }
    }
}
