using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
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
    public SelectedObjects selectedObjects3;

    public GameObject other_gameObject;
    //public Score score;
    private bool ObjInactive;
    //  public GameObject ring;


    public IntData scoreValue;
 
    public Text text;

    private void Start()

    {
        scoreValue.value = 1;
        text = text.GetComponent<Text>();
   
    }

    private void Update()
    {
        text.text = scoreValue.value.ToString();


        // score = score.GetComponent<Score>();

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

        selectedObjects3 = selectedObjects3.GetComponent<SelectedObjects>();

        if (currentWeapon.activeSelf == false)
        {
            selectedObjects3.SelectedObject();
        }
    }



private void OnTriggerEnter(Collider other)
    {

    Otheridholder = other.gameObject.GetComponent<IDholder>();
    otheridholder2 = Otheridholder.idObj;
    other_gameObject = other.gameObject;


        if (idholder2 == currentcharholder2)
        {
            if (otheridholder2 == currentwepholder2)
            {

                AddScores();
                // this.gameObject.SetActive(false);
                // other.gameObject.SetActive(false);
                // currentWeapon.SetActive(false);
                //  currentChar.SetActive(false);

                //  selectedObjects3.SelectedObject();


            }

        }

        
    }

    public void AddScores()
    {

      



            scoreValue.value +=  1;



    }
}






