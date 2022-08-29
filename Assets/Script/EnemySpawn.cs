using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] spawnPoints;
    private int randomSpawn;
    private float timer = 2.0f;
    public GameObject[] enemyTypes;


    private void Update()
    {
        if(timer == 0)
        {
            randomSpawn = Random.Range(0, spawnPoints.Length);
        }
    }

}
