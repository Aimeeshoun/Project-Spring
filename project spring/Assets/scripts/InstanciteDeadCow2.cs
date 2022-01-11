using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciteDeadCow2 : MonoBehaviour
{

    public GameObject deadcow;
    public GameObject deadcow2;
    public GameObject this_gamObj;
    public Transform this_gamObj_position;
    private int index;
    private bool spawning;
    private bool spawning2;
    public float spawnRate;




    public void Start()
    {
        this_gamObj = this.gameObject.GetComponent<GameObject>(); 

    }
    // Update is called once per frame
    public void Update()
    {
      

    }


    public IEnumerator Killcow()
    {
        deadcow = Instantiate(deadcow, this_gamObj.transform.position, this_gamObj.transform.rotation) as GameObject;
        deadcow.transform.parent = gameObject.transform;
        Destroy(deadcow, 2f);
        yield return new WaitForSeconds(spawnRate);
        spawning = false;

    }
    public IEnumerator Killcow2()
    {
        deadcow2 = Instantiate(deadcow2, this_gamObj.transform.position, this_gamObj.transform.rotation) as GameObject;
        deadcow2.transform.parent = gameObject.transform;
        Destroy(deadcow2, 2f);
        yield return new WaitForSeconds(spawnRate);
        spawning2 = false;

    }

}
