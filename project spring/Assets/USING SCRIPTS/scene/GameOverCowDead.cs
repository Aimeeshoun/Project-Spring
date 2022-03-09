using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverCowDead : MonoBehaviour
{

    public GameObject[] cowsAlive_;
    public GameObject[] cowsdead;
    public object cow;
 
    public bool isAlive;


    public GameObject skull;
    public GameObject target;
    public Transform targetTrans;
    public Vector3 targetVec;
    public Quaternion targetquar;
    public GameObject newskull;

    public bool isTime;
    public bool GameOverMan;
    public bool Skull;
    public void Start()
    {
        skull = GameObject.FindGameObjectWithTag("skullpar");
        target = GameObject.FindGameObjectWithTag("skulltaget");
    }
    public void Update()
    {

      

        cowsAlive_ = GameObject.FindGameObjectsWithTag("Cowbox");

        targetTrans= target.transform;
        targetVec = targetTrans.position;
        targetquar = targetTrans.rotation;



        isAlive = true;

      
        

        if (isAlive)
        {
            if (cowsAlive_.Length <= 0)
            {




                StartCoroutine(SkullBorn2());
                SkullBorn2();
                
               

            }
        }
    }

    public void GameOverScene()
    {
        SceneManager.LoadScene("game over menu");
    }

  
    public IEnumerator SkullBorn2()
    {

        if (!Skull)
        {
            newskull = Instantiate(skull, targetVec, targetquar) as GameObject;
            Skull = true;
        }
      
        Destroy(newskull, 1f);

        yield return new WaitForSeconds(.4f);

        GameOverScene();
    }
}

