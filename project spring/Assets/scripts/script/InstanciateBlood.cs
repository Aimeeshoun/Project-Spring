using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciateBlood : MonoBehaviour
{
    public GameObject[] bloodsplatter;  
    private int index;
    private bool spawning;
    public GameObject currentBlood;
    /// 
    public float spawnRate;
    public SpawnRandomPoints selectedObjects2;
    public GameObject currentWeapon;
    public GameObject position;
    // Start is called before the first frame update
    public SpawnRandomPoints spawnRandomPoints;
    /// <summary>
    /// /
    /// </summary>
    void Start()
    {

        selectedObjects2 = GameObject.Find("Enemy Spawner").GetComponent<SpawnRandomPoints>();
      
    
    }

    // Update is called once per frame
    void Update()
    {
     
        currentWeapon = selectedObjects2.currentWeapon;
        position = selectedObjects2.currentPoint;





        if (currentWeapon.activeSelf == false)
        {
            StartCoroutine(BloodSplasts());
            BloodSplasts();
        }
    }
    public IEnumerator BloodSplasts()
        {



            selectRandomObjects();
            //spawning = true;

            currentBlood = Instantiate(currentBlood, position.transform.position, position.transform.rotation) as GameObject;
            currentBlood.transform.parent = gameObject.transform;
            Destroy(currentBlood, .1f);
            yield return new WaitForSeconds(spawnRate);
            spawning = false;

        }

        public void selectRandomObjects()

        {


            index = Random.Range(0, bloodsplatter.Length);
            currentBlood = bloodsplatter[index];
            

        }
} 



    






