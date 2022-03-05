using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class StopAiSpeed : MonoBehaviour
{


    public GameObject bear;
    public NavMeshAgent agent2_;
    public float speed = 0;
    public float currentSpeed;
    public FreezeAI Freeze_;
    public GameObject freezeObj;
    public bool ishit3;

    public ClickFreeze click_;
    public GameObject[] lighting;
    public GameObject[] lightingchild;
    public Transform lightchildtrans;

    // Start is called before the first frame update
    void Start()
    {
        bear = this.gameObject;
        agent2_= bear.GetComponent<NavMeshAgent>();
        currentSpeed= agent2_.speed;

    }

    // Update is called once per frame
    void Update()
    {
        if (ishit3)
        {
            agent2_.speed = speed;
        }

        lighting = GameObject.FindGameObjectsWithTag("WeaponRandomObj");

        foreach (GameObject light in lighting)
        {
            lightingchild[0] = light.transform.GetChild(6).gameObject;

            foreach (GameObject light2 in lightingchild)
            {
                click_ = light2.GetComponent<ClickFreeze>();

                ishit3 = click_.istrueee;
            }

           
      


        }
        freezeObj = GameObject.FindGameObjectWithTag("freezeai");
        Freeze_= freezeObj.GetComponent<FreezeAI>();
      
       
    }
}
