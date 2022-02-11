using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranlatetoPosition : MonoBehaviour
{



    /// </summary>
    public GameObject obj_;
    private int index;
    private bool spawning;

    public float spawnRate;

    public GameObject parentObj_;
    public GameObject position;
    public GameObject newObj;
  
    /// /
    /// </summary>
    /// 
    // Start is called before the first frame update
    void Start()
    {





}

    // Update is called once per frame
    void Update()
    {
      
    }


    public IEnumerator TranslateObj()
    {

        //  foreach (GameObject currentBlood_ in currentBlood)
        //  {
        newObj = Instantiate(obj_, position.transform.position, position.transform.rotation);
        newObj.transform.parent = parentObj_.transform;
      //  Destroy(obj_, 2f);
        yield return new WaitForSeconds(spawnRate);
        spawning = false;

        // }


    }
     public   void TranlateObj()
{
    StartCoroutine(TranslateObj());
        TranslateObj();


}


}



