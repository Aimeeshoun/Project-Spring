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


    public void Awake()
    {
        the_obj = this.gameObject;
        meshRenderer_ = the_obj.GetComponent<MeshRenderer>();
        the_mats = meshRenderer_.materials;
        the_mat = the_mats[1];
        the_mat2 = the_mats[2];
    }

}




