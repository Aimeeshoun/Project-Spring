using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciteDeadCow2 : MonoBehaviour
{

    public GameObject deadcow;
    public GameObject deadcow2;
    public GameObject this_gamObj;
    public GameObject this_gamObj2;

    private bool spawning;
    private bool spawning2;
    public float spawnRate;
    public Transform position_;
    public Vector3 _postion;
    public Quaternion _rotation;

    public void Start()
    {
        //   this_gamObj = this.gameObject;
        //  this_gamObj = this_gamObj.GetComponentInChildren<GameObject>();
       
    //    this_gamObj2= this_gamObj.GetComponentInChildren<GameObject>()as GameObject;
    }
    // Update is called once per frame
    public void Update()
    {
        
        position_ = this_gamObj2.GetComponent<Transform>();
        _postion = position_.position;
        _rotation = position_.rotation;

    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Fuzzy")
        {
            
            StartCoroutine(Killcow());
            Killcow();
            this_gamObj.SetActive(false);
        }
    }
   
       



    public IEnumerator Killcow()
    {
        deadcow = Instantiate(deadcow, _postion, _rotation) as GameObject;
        deadcow.transform.parent = gameObject.transform;
        Destroy(deadcow, 4f);
        yield return new WaitForSeconds(spawnRate);
        spawning = false;
        StartCoroutine(Killcow2());
        Killcow2();

    }
    public IEnumerator Killcow2()
    {
        deadcow2 = Instantiate(deadcow2, this_gamObj.transform.position, this_gamObj.transform.rotation) as GameObject;
        deadcow2.transform.parent = gameObject.transform;
        Destroy(deadcow2, 4f);
        yield return new WaitForSeconds(spawnRate);
        spawning2 = false;

    }

}
