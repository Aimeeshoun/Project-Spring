using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killfuzzy : MonoBehaviour
{

    public GameObject bloodsplatter;

    private bool spawning;

    public GameObject currentBlood__;
    /// 
    public float spawnRate;

    public GameObject target;

    public GameObject other_gameObject;
    public GameObject this_gameObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        other_gameObject = other.gameObject;
          if (other.tag == "Fuzzy")
        {

            BloodSplasts();
      //      BloodSplasts();
            Destroy(other_gameObject);
        }

    }


    public void  BloodSplasts()
    {

      
        currentBlood__ = Instantiate(currentBlood__, other_gameObject.transform.position, other_gameObject.gameObject.transform.rotation) as GameObject;
        currentBlood__.transform.parent = gameObject.transform;
        Destroy(currentBlood__, 3f);
     

       

    }

    public void DestroyBomb()
    {
        Destroy(this.gameObject,3f);
    }

}