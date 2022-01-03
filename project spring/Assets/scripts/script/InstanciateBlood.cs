using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciateBlood : MonoBehaviour
{
    public GameObject bloodsplatter;  
    private int index;
    private bool spawning;
    public GameObject currentBlood;
    /// 
    public float spawnRate;
    public SpawnRandomPoints selectedObjects2;

    public GameObject position;
    // Start is called before the first frame update
    public SpawnRandomPoints spawnRandomPoints;
    /// <summary>
    /// /
    /// </summary>
    /// 


    void Start()
    {

        selectedObjects2 = GameObject.Find("Enemy Spawner").GetComponent<SpawnRandomPoints>();

   






    }

    // Update is called once per frame
    void Update()
    {
      
        position = selectedObjects2.currentPoint;

        StartCoroutine(BloodSplasts());
        BloodSplasts();






    }
    public IEnumerator BloodSplasts()
        {



            currentBlood = Instantiate(currentBlood, position.transform.position, position.transform.rotation) as GameObject;
            currentBlood.transform.parent = gameObject.transform;
            Destroy(currentBlood, .3f);
            yield return new WaitForSeconds(spawnRate);
            spawning = false;

        }




} 



    







