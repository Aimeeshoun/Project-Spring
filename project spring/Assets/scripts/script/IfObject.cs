using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfObject : MonoBehaviour
{

    public CollectionSO[] CharacterSOList;
   
  
   
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {


        for (int i = 0; i < CharacterSOList.Length; i++)
        {

                if (this.gameObject == other.gameObject)

                //  if (ObjectTag ==CurrentTag)
                {

                }

                else
                {


                }
            }
        }

    }





