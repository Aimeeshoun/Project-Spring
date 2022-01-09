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


    public GameObject position;

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

        position = this.gameObject;
    }


    public IEnumerator TranslateObj()
    {

        //  foreach (GameObject currentBlood_ in currentBlood)
        //  {
        obj_= Instantiate(obj_, position.transform.position, position.transform.rotation) as GameObject;
        obj_.transform.parent = gameObject.transform;
      //  Destroy(obj_, 2f);
        yield return new WaitForSeconds(spawnRate);
        spawning = false;

        // }


    }
        void TranlateObj()
{
    StartCoroutine(TranslateObj());
        TranslateObj();


}


}



