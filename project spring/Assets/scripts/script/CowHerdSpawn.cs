using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowHerdSpawn : MonoBehaviour
{
    public GameObject[] myCharacterList;
    public GameObject[] spawnPoints;
    private GameObject currentPoint;
    private int index;
    public int spawnAmount;
    public float spawnRate;
    private bool spawning;


    public float destroytime;

    public float maxTime;
    public float minTime;
    private float spawnTime;

    private float time;
    public GameObject currentCharacter;
    private int index2;


    public float maxSpawnPerSecond;
    private float timer;

    public GameObject particle_obj;
    public ParticleSystem _the_particleSystem;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("cow herd spawn point");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void selectRandomObjects()

    {

        myCharacterList = GameObject.FindGameObjectsWithTag("Cowbox");
        index = Random.Range(0, myCharacterList.Length);
        currentCharacter = myCharacterList[index];
        index = Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[index];

    }
    public IEnumerator SpawnMonster()
    {

        selectRandomObjects();
        //spawning = true;

        currentCharacter = Instantiate(currentCharacter, currentPoint.transform.position, currentPoint.transform.rotation) as GameObject;
        // currentCharacter.transform.parent = gameObject.transform;
        //  Destroy(currentCharacter, destroytime);
        yield return new WaitForSeconds(spawnRate);
        spawning = false;

    }

}





