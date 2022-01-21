using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Access4 : MonoBehaviour
{


    public IDholder Otheridholder;


    public ID otheridholder2;

    public ID currentcharholder2;

    public IDholder _selCharIdholder;




   public GameObject currentChar;

    public SelectedObjects selectedObjects2;
  public SelectedObjects selectedObjects3;

  public GameObject other_gameObject;

 public UnityEvent Destorys;





    void Start()
    {


  
       
        selectedObjects2 = GameObject.Find("character spawner sel").GetComponent<SelectedObjects>();
    }


    void Update()
    {



    //    currentcharholder2 = selectedObjects2.currentwepholder2;


       

        selectedObjects3 = selectedObjects3.GetComponent<SelectedObjects>();

        if (currentChar.activeSelf == false)
        {
            selectedObjects3.SelectedObject();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        Otheridholder = other.gameObject.GetComponent<IDholder>();
        otheridholder2 = Otheridholder.idObj;
        other_gameObject = other.gameObject;


            if (otheridholder2 == currentcharholder2)
            {
         

         
                Destorys.Invoke();
                

                currentChar.SetActive(false);

            selectedObjects3.SelectedObject();

            Destroy(other.gameObject);
       

                
            }


     
    }
}





