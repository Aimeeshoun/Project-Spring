using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour
{


    public GameObject bloodsplatter;

    private bool spawning;

    public GameObject currentBlood__;
    /// 
    public float spawnRate;
    public SelectedObjects selectedObjects2;




    public IDholder Otheridholder;


    public ID otheridholder2;

    public ID currentcharholder2;

    public IDholder _selCharIdholder;

    public GameObject target;


    public GameObject currentChar;

    public SelectedObjects selectedObjects3;

    public GameObject other_gameObject;
    public GameObject this_gameObject;
 

    void Start()
    {

        selectedObjects2 = GameObject.Find("character spawner sel").GetComponent<SelectedObjects>();
    }
    // Update is called once per frame
    void Update()
    {
      

        currentcharholder2 = selectedObjects2.currentwepholder2;

        Otheridholder = this.gameObject.GetComponent<IDholder>();
        otheridholder2 = Otheridholder.idObj;


        selectedObjects3 = selectedObjects3.GetComponent<SelectedObjects>();
   

       

        if (currentChar.activeSelf == false)
        {
            selectedObjects3.SelectedObject();
        }
    }


    void OnMouseDown()
    {
      
       

    if (otheridholder2 == currentcharholder2)
    {



        StartCoroutine(BloodSplasts());
        BloodSplasts();
        Destroy(this.gameObject,3f);



    }

       if (otheridholder2 != currentcharholder2)
        {

            TryagainScene();


        }

}

    public void TryagainScene()
    {
        SceneManager.LoadScene("game over menu");
    }




    public IEnumerator BloodSplasts()
    {

        //  foreach (GameObject currentBlood_ in currentBlood)
        //  {
        currentBlood__ = Instantiate(currentBlood__, this.gameObject.transform.position, this.gameObject.transform.rotation) as GameObject;
        currentBlood__.transform.parent = gameObject.transform;
        Destroy(currentBlood__, 3f);
        yield return new WaitForSeconds(spawnRate);
        spawning = false;

        // }


    }




 


}