using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NweSpawner : MonoBehaviour
{
    public GameObject[] spawnPoints;
    GameObject currentPoint;
    int index;
    public GameObject[] human;
    public float minTimeToSpawn;
    public float maxTimeToSpawn;
    public bool canSpawn;
    public float spawnTime;
    public int humanNo;
    public bool spawnDone;
    public GameObject spawnerDoneGameObject;
   
    

    public void Start()
    {
        spawnTime = 50f;
        Invoke("SpawnHuman", 0.5f);
        
    }

    private void Update()
    {
        if (canSpawn)
        {
            spawnTime -= Time.deltaTime;
            if (spawnTime <= 0)
            {
                canSpawn = false;
                FindObjectOfType<PlayerController>().WinGame();
            }
        }
       
    }
    void SpawnHuman()
    {
        index = Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[index];
        float timeBtwSpawns = Random.Range(minTimeToSpawn, maxTimeToSpawn);
        if(canSpawn)
        {
            Instantiate(human[Random.Range(0, human.Length)],transform.position,Quaternion.identity);
            humanNo++;
        }
        
        Invoke("SpawnHuman", timeBtwSpawns);

        if(spawnDone==true)
        {
            spawnerDoneGameObject.SetActive(true);
        }

        
    }
}
