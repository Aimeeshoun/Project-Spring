using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenseMaker2 : MonoBehaviour
{
 //    public Vector3[] linePoints;
    public Ray ray_;
    public Ray ray2_;
    float timer;
    public float timerdelay;
   LineRenderer lineREnder;
    public Vector3 linePoint;
    public Vector3 linePoint2;
    public Vector3 linePoint3;
    public Vector3 linePoint4;
    private GameObject newLine;
    public GameObject linePrefab;

    public FenseMaker2 fenseMaker_;
    public GameObject scriptHolder;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
     

        if (Input.GetMouseButtonDown(0))
        {
            Debug.DrawRay(Camera.main.ScreenToViewportPoint(Input.mousePosition), linePoint);
            ray_ = Camera.main.ScreenPointToRay(Input.mousePosition);
            linePoint = ray_.origin + ray_.direction * 10;
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.DrawRay(Camera.main.ScreenToViewportPoint(Input.mousePosition), linePoint2);
            ray2_ = Camera.main.ScreenPointToRay(Input.mousePosition);
            linePoint2= ray2_.origin + ray2_.direction * 10;

        }


    }

  
}
