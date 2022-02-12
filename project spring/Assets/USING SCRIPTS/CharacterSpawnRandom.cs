using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawnRandom : MonoBehaviour

{

    public GameObject[] myCharacterList;
    public GameObject[] spawnPoints;
    private GameObject currentPoint;
    private int index;
    public int spawnAmount;
    public float spawnRate;
    private bool spawning;
    public float maxTime;
    public float minTime;
    private float spawnTime;
    private float time;
    public GameObject currentCharacter;
    public float maxSpawnPerSecond;
    private float timer;
    public GameObject particle_obj;
    public ParticleSystem _the_particleSystem;

    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint 2");
        SetRandomTime();
        time = 0;
        selectRandomObjects();
        StartCoroutine(SpawnMonster());
        SpawnMonster();
        _the_particleSystem = particle_obj.GetComponent<ParticleSystem>();

    }

    void FixedUpdate()
    {

        time += Time.deltaTime;
        if (time >= spawnTime)
        {
            if (transform.childCount < spawnAmount && spawning == false)
            {

                if (maxSpawnPerSecond > 0)
                {
                    timer -= Time.deltaTime;

                    if (timer <= 0)
                    {
                       
                        StartCoroutine(SpawnMonster());
                        SpawnMonster();
                        SetRandomTime();

                        time = 0;

                    }
                }


            }
        }
    }

    public IEnumerator SpawnMonster()
    {

        selectRandomObjects();
        currentCharacter = Instantiate(currentCharacter, currentPoint.transform.position, currentPoint.transform.rotation) as GameObject;
        yield return new WaitForSeconds(spawnRate);
        spawning = false;

    }

    public void selectRandomObjects()

    {

        index = Random.Range(0, myCharacterList.Length);
        currentCharacter = myCharacterList[index];
        index = Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[index];

    }


    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);

    }
}


