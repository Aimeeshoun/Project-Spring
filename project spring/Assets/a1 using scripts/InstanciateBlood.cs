using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciateBlood : MonoBehaviour
{
    public GameObject bloodsplatter;
    private int index;
    private bool spawning;
  //  public GameObject[] currentBlood;
   // public GameObject currentBlood_;
    public GameObject currentBlood__;
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

   






    }

    // Update is called once per frame
    void Update()
    {
      
        position = this.gameObject;




    }
    void OnMouseDown()
    {
        StartCoroutine(BloodSplasts());
            BloodSplasts();

        
    }


    public IEnumerator BloodSplasts()
        {

      //  foreach (GameObject currentBlood_ in currentBlood)
      //  {
            currentBlood__ = Instantiate(currentBlood__, position.transform.position, position.transform.rotation) as GameObject;
            currentBlood__.transform.parent = gameObject.transform;
         //   Destroy(currentBlood__, 2f);
            yield return new WaitForSeconds(spawnRate);
            spawning = false;

       // }

     
        }




} 
