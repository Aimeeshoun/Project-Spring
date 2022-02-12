using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranlatetoPosition : MonoBehaviour
{

    public GameObject obj_;
    private int index;
    private bool spawning;
    public float spawnRate;
    public GameObject parentObj_;
    public GameObject position;
    public GameObject newObj;
  
    public IEnumerator TranslateObj()
    {

        newObj = Instantiate(obj_, position.transform.position, position.transform.rotation);
        newObj.transform.parent = parentObj_.transform;
        yield return new WaitForSeconds(spawnRate);
        spawning = false;

    }
     public   void TranlateObj()
{
    StartCoroutine(TranslateObj());
    TranslateObj();

}

}



