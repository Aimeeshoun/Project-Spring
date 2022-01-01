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
    private int index2;


    public float maxSpawnPerSecond;
    private float timer;

    // Use this for initialization
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint 2");

        // myCharacterList = GameObject.FindGameObjectsWithTag("CharacterRandomObj");
        SetRandomTime();
        time = 0;
        selectRandomObjects();
        StartCoroutine(SpawnMonster());
        SpawnMonster();
    }

    // Update is called once per frame
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

                     //  timer = 1 / maxSpawnPerSecond;
                    }
                }


            }
        }
    }

    public IEnumerator SpawnMonster()
    {

        selectRandomObjects();
        //spawning = true;
    
        currentCharacter = Instantiate(currentCharacter, currentPoint.transform.position, currentPoint.transform.rotation) as GameObject;
        currentCharacter.transform.parent = gameObject.transform;
        Destroy(currentCharacter, 3.4f);
        yield return new WaitForSeconds(spawnRate);
        spawning = false;

    }

    public void selectRandomObjects()

    {
     
       // myCharacterList = GameObject.FindGameObjectsWithTag("CharacterRandomObj");
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


