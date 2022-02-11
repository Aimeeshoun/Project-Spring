using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciateDeadCow : MonoBehaviour
{

   
    public GameObject dead_cow;
    /// 
    public float spawnRate;
    public bool spawning;

    public GameObject position;
    // Start is called before the first frame update

    /// <summary>
    /// /
    /// </summary>
    /// 


    void Start()
    {








    }

    // Update is called once per frame
    void Update()
    {

        position = this.gameObject;




    }
    void OnMouseDown()
    {
        StartCoroutine(CowDeaths());
        CowDeaths();


    }


    public IEnumerator CowDeaths()
    {

        //  foreach (GameObject currentBlood_ in currentBlood)
        //  {
        dead_cow = Instantiate(dead_cow, position.transform.position, position.transform.rotation) as GameObject;
        dead_cow.transform.parent = gameObject.transform;
        Destroy(dead_cow, 2f);
        yield return new WaitForSeconds(spawnRate);
        spawning = false;

        // }


    }




} 
