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

    /// </summary>


    // Start is called before the first frame update
    void Start()
    {
        iDholder = this.gameObject.GetComponent<IDholder>();
        idholder2 = iDholder.idObj;
        

        //  myWeaponList2 = GameObject.FindGameObjectsWithTag("WeaponRandom");
        // index = Random.Range(0, myWeaponList2.Length);
        //   currentWeapon = myWeaponList2[index];
        //    currentWeapon = Instantiate(currentWeapon, target.transform.position, target.transform.rotation) as GameObject;
        //    currentWeapon.transform.parent = gameObject.transform;


        //index2 = Random.Range(0, myCharacterList2.Length);
        // currentChar = myCharacterList2[index2];
        //  currentChar2 = Instantiate(currentChar, target2.transform.position, target2.transform.rotation) as GameObject;
        //   currentChar.transform.parent = gameObject.transform;

    }


    // Update is called once per frame
    void Update()
    {


        selectedObjects = GameObject.Find("weaponspawner").GetComponent<SelectedObjects>();
        currentWeapon = selectedObjects.currentWeapon;
        _selWepIdholder = currentWeapon.GetComponent<IDholder>();
        currentwepholder2 = _selWepIdholder.idObj;



       
        iDholder = this.gameObject.GetComponent<IDholder>();
        idholder2 = iDholder.idObj;
        /////

   

        selectedObjects2 = GameObject.Find("character spawner sel").GetComponent<SelectedObjects>();
        currentChar = selectedObjects2.currentWeapon;

        _selCharIdholder = currentChar.GetComponent<IDholder>();
        currentcharholder2 = _selCharIdholder.idObj;

    
      
    }

    public void OnTriggerEnter(Collider other)
    {
        Otheridholder = other.gameObject.GetComponent<IDholder>();
        otheridholder2 = Otheridholder.idObj;



        if (idholder2 == currentwepholder2)
        {
            if (otheridholder2 == currentcharholder2)
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
                Destroy(currentWeapon);
                Destroy(currentChar);
            }

        }
    }

}




