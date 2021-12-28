using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessTag3 : MonoBehaviour
{

   

    public GameObject _currentWeaponSel;
    public GameObject _currentCharSel;

    public GameObject _currentWeaponSelID;
    public GameObject _currentCharacterSelID;

    public GameObject _otherID;
    public GameObject _thisID;

    public IDholder _thisidholder;
    public IDholder _otherdholder;
    public IDholder _selWepIdholder;
    public IDholder _selCharIdholder;

    public SelectedObjects currentWeaponSel;
    public SelectedChar _selectedChar;
    public SelectedObjects _selectedObjects;

    //
    public IDholder _thisidholder2;
    //
    void Start()
    {




        



        ///
        _thisidholder = this.gameObject.GetComponent<IDholder>();
        _thisID = GameObject.Find(_thisidholder.idObj.name);
        print(_thisID);





        ////

        _selectedChar = _selectedChar.GetComponent<SelectedChar>();
        _thisidholder = this.gameObject.GetComponent<IDholder>();
        _currentCharSel = GameObject.Find(_thisidholder.idObj.name);

        currentWeaponSel = currentWeaponSel.GetComponent<SelectedObjects>();


        _selWepIdholder = _selWepIdholder.GetComponent<IDholder>();
        _thisidholder = this.gameObject.GetComponent<IDholder>();

        _currentWeaponSelID = GameObject.Find(_selWepIdholder.idObj.name);
        _selWepIdholder = this.gameObject.GetComponent<IDholder>();

        _selCharIdholder = _selCharIdholder.GetComponent<IDholder>();
        _currentCharacterSelID = GameObject.Find(_thisidholder.idObj.name);
        _thisidholder = this.gameObject.GetComponent<IDholder>();


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OntriggerEnter(Collider other)

    {


        _otherdholder = other.gameObject.GetComponent<IDholder>();

        _otherID = GameObject.Find(_thisidholder.idObj.name);




        //  if (_thisidholder == _selWeapId)
        // {
        //      if (_otherdholder == selcharidtag)
        //      {

        //         Destroy(_selWeap);
        //         Destroy(_selChar);
        //        Destroy(this.gameObject);
        //          Destroy(other.gameObject);

        //     }
        //  }



        //  }
        //}
    }
}