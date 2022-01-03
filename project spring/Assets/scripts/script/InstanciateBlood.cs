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
    /// 
   

    public AddScore _skull;
    public AddScore _alien;
    public AddScore _devil;
    public bool _isgoingup;
    public bool _isgoingup2;
    public bool _isgoingup3;
    public bool _isgoingup4;


    void Start()
    {

        selectedObjects2 = GameObject.Find("Enemy Spawner").GetComponent<SpawnRandomPoints>();
       
        _skull =  GameObject.Find("skull r s").GetComponent<AddScore>();
        _alien =  GameObject.Find("devil r s").GetComponent<AddScore>();
        _devil =  GameObject.Find("alien r s").GetComponent<AddScore>();
       
      
        
        
        
        

        _isgoingup2 = _skull.isgoingup;
        _isgoingup3 = _alien.isgoingup;
        _isgoingup4 = _devil.isgoingup;



    }

    // Update is called once per frame
    void Update()
    {

        if (_isgoingup2 || _isgoingup3 || _isgoingup4)
        {
            StartCoroutine(BloodSplasts());
            BloodSplasts();
        }



     
        currentWeapon = selectedObjects2.currentWeapon;
        position = selectedObjects2.currentPoint;




    }
    public IEnumerator BloodSplasts()
        {



            selectRandomObjects();
            //spawning = true;

            currentBlood = Instantiate(currentBlood, position.transform.position, position.transform.rotation) as GameObject;
            currentBlood.transform.parent = gameObject.transform;
            Destroy(currentBlood, .3f);
            yield return new WaitForSeconds(spawnRate);
            spawning = false;

        }

        public void selectRandomObjects()

        {


            index = Random.Range(0, bloodsplatter.Length);
            currentBlood = bloodsplatter[index];
            

        }
} 



    







