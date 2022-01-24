using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cHANGEcOLOR : MonoBehaviour
{

    public GameObject the_obj;
    public MeshRenderer meshRenderer_;
    public Material[] the_mats;
  public Material the_mat;
  public Material the_mat2;
    public Color color_;



    // Start is called before the first frame update
    public void Start()
    {
       
      //the_mats[0] = the_mat;

    }
    public void Awake()
    {
        the_obj = this.gameObject;
        meshRenderer_ = the_obj.GetComponent<MeshRenderer>();
        the_mats = meshRenderer_.materials;
        the_mat = the_mats[1];
        the_mat2 = the_mats[2];
    }
    // Update is called once per frame
    public void Update()
    {
     

       



     
    }



    public void ChangeColor()
    {

        //  the_mats[0] = the_mat2;

        the_obj.GetComponent<Renderer>().material = the_mat2;


    }


    public void ChangeBackColor()
    {
        //the_mats[0] = the_mat;

        the_obj.GetComponent<Renderer>().material = the_mat;
    }
}




