using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
[RequireComponent(typeof(Collider))]
public class OnTriggerEnterEvent : MonoBehaviour



{



 //   public IDholder iDholder;
  //  public IDholder Otheridholder;

  //  public ID idholder2;
  //  public ID otheridholder2;
  //  public ID currentwepholder2;
  //  public ID currentcharholder2;
    //
   // public GameObject _otherID;
   // public GameObject _thisID;
   // public GameObject _selwepidname;
  //  public GameObject _selcharidname;
  //  public IDholder _selWepIdholder;
  //  public IDholder _selCharIdholder;



  //  public GameObject currentWeaponSel2;
  //  public GameObject currentCharacterSel2;



   // public GameObject currentGameObject;

   // public GameObject currentGameObject3;




   // public GameObject currentWeapon;
   // public GameObject currentChar;
   // public GameObject currentChar2;


   // public GameObject weaponspawner;
   // public SelectedObjects selectedObjects;
   // public SelectedObjects selectedObjects2;
   // public SelectedObjects selectedObjects3;

  //  public GameObject other_gameObject;
/// <summary>
/// /
/// </summary>
    //  public GameObject ring;




    public void Start()
    {

      //  selectedObjects2 = GameObject.Find("character spawner sel").GetComponent<SelectedObjects>();
       // selectedObjects3 = selectedObjects3.GetComponent<SelectedObjects>();
    }
    public void Update()
    {
     //   currentcharholder2 = selectedObjects2.currentwepholder2;
     //   GetComponent<Collider>().isTrigger = true;
    }

 

    public UnityEvent triggerEnterEvent, triggerExitEvent;
    void OnTriggerEnter(Collider other)
    {
       // Otheridholder = other.gameObject.GetComponent<IDholder>();
       // otheridholder2 = Otheridholder.idObj;
       // other_gameObject = other.gameObject;


      //  if (otheridholder2 == currentcharholder2)
      //  {

            triggerEnterEvent.Invoke();
     //   }
    }
    private void OnTriggerExit(Collider other)
    {
     //   Otheridholder = other.gameObject.GetComponent<IDholder>();
      //  otheridholder2 = Otheridholder.idObj;
     //   other_gameObject = other.gameObject;


       // if (otheridholder2 == currentcharholder2)
       // {

         
            triggerExitEvent.Invoke();
       
     //   }


    } 

}
