using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHerd2 : MonoBehaviour
{

    public GameObject[] myCharacterList;
    public GameObject[] spawnPoints;
    private GameObject currentPoint;
    private int index;
    private float time = 0;
    public GameObject currentCharacter;
    private int index2;
    bool isSpawning = false;


    public void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("cow herd spawn point");
   
       
       for (int i = 0; i < 1; i++)
        {
          
            StartCoroutine(SpawnObject());
            
        }

     
    }
    public void Update()
    {
        myCharacterList = GameObject.FindGameObjectsWithTag("Cowbox");
        time += Time.deltaTime;
        if (!isSpawning)
        {
            StartCoroutine(SpawnObject());
            SpawnObject();
            isSpawning = true; 
        }
    }

 public void selectRandomObjects()

  {
      index = Random.Range(0, myCharacterList.Length);
      currentCharacter = myCharacterList[index];
      index2= Random.Range(0, spawnPoints.Length);
      currentPoint = spawnPoints[index2];
  }

    IEnumerator SpawnObject()
    {

        selectRandomObjects();
        currentCharacter = Instantiate(currentCharacter, currentPoint.transform.position, currentPoint.transform.rotation) as GameObject;
        yield return new WaitForSeconds(15);   
        isSpawning = false;
    }

}



