using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Access4 : MonoBehaviour
{

    public IDholder iDholder;
    public IDholder Otheridholder;

    public ID idholder2;
    public ID otheridholder2;
    public ID currentwepholder2;
    public ID currentcharholder2;
    //
    public GameObject _otherID;
    public GameObject _thisID;
    public GameObject _selwepidname;
    public GameObject _selcharidname;
    public IDholder _selWepIdholder;
    public IDholder _selCharIdholder;



    public GameObject currentWeaponSel2;
    public GameObject currentCharacterSel2;

   
  
    public GameObject currentGameObject;

    public GameObject currentGameObject3;


    /// <summary>
    /// /
    /// 
    public GameObject[] myWeaponList2;
    public GameObject[] myCharacterList2;

    public GameObject currentWeapon;
    public GameObject currentChar;
    public GameObject currentChar2;
    private int index;
    private int index2;
    public GameObject target;
    public GameObject target2;
    
    public GameObject weaponspawner;
    public SelectedObjects selectedObjects;
    public SelectedObjects selectedObjects2;
  
    public GameObject other_gameObject;

  //  public GameObject ring;
    //private GameObject ring_animation_;
   // private Animation ring_animation;


    /// </summary>


    // Start is called before the first frame update
    void Start()
    {
    


       // ring_animation_ = GameObject.Find("ring r s").GetComponent<GameObject>();
       // ring_animation = ring_animation_.GetComponent<Animation>();
        //ring = GameObject.Find("rings animation group").GetComponent<GameObject>();

    }


    // Update is called once per frame
    void Update()
    {
 

        selectedObjects = GameObject.Find("weaponspawner").GetComponent<SelectedObjects>();
        currentWeapon = selectedObjects.currentWeapon;
        _selWepIdholder = currentWeapon.GetComponent<IDholder>();
        currentwepholder2 = _selWepIdholder.idObj;
        

        ///



        selectedObjects2 = GameObject.Find("character spawner sel").GetComponent<SelectedObjects>();
        currentChar = selectedObjects2.currentWeapon;

        _selCharIdholder = currentChar.GetComponent<IDholder>();
        currentcharholder2 = _selCharIdholder.idObj;


        ///


        iDholder = this.gameObject.GetComponent<IDholder>();
        idholder2 = iDholder.idObj;
        /////

   

    }

    public void OnTriggerEnter(Collider other)
    {
        Otheridholder = other.gameObject.GetComponent<IDholder>();
        otheridholder2 = Otheridholder.idObj;
        other_gameObject = other.gameObject;


        if (idholder2 == currentwepholder2)
        {
            if (otheridholder2 == currentcharholder2)
            {
                //   ring = Instantiate(ring, other.gameObject.transform.position, other.gameObject.transform.rotation) as GameObject;
                // ring.transform.parent = gameObject.transform;
                // ring_animation.Play("ring r s");

                GameManager.instance.IncrementScore();
                Destroy(this.gameObject);
                Destroy(other.gameObject);

                selectedObjects.NewWeapon();

                //electedObjects.SelectedObject();

            }

        }
    }

}





