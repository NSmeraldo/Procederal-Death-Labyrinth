using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public GameObject[] Items;
    

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Items[Random.Range(0, Items.Length - 1)], transform.position, Quaternion.identity);
    }


}