using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomPoints : MonoBehaviour
{

    public GameObject monster;
    public GameObject[] spawnPoints;
    private GameObject currentPoint;
    private int index;
    public int spawnAmount = 5;
    public float spawnRate = 5.0f;
    public int health;
    private bool spawning;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.childCount < spawnAmount && spawning == false)
        {
            StartCoroutine(SpawnMonster());
            SpawnMonster();
        }

    }

    public IEnumerator SpawnMonster()
    {
        spawning = true;
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        index = Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[index];
        monster = Instantiate(monster, currentPoint.transform.position, currentPoint.transform.rotation) as GameObject;
        monster.transform.parent = gameObject.transform;
        yield return new WaitForSeconds(spawnRate);
        spawning = false;
    }
}ccdd wew 