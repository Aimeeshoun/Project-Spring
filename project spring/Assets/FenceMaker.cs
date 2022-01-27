using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceMaker : MonoBehaviour
{

    public List<Vector3> linePoints;
    public float timer = 0;
    public float timer2 = 0;


    public GameObject currentLine;
    public LineRenderer lineREnder;
    public float lineWidth = 5;
    public Material mat;
    public GameObject linePrefab;


    public Ray ray_;


    public Vector3 startPos;
    public Vector3 endPos;
    public GameObject newLine;

    public List<Vector3> positions_;

    public Vector3 World_point;

    public void Start()
    {

    }

    public void Awake()
    {

    }


    public void Update()

    {
        lineREnder.positionCount = 2;
        if (Input.GetMouseButtonDown(0))
        {


            timer = 1;
 
            if (timer == 1)
            {

                World_point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                //   lineREnder.SetPosition(0, startPos);
                    linePoints.Add(GetMousePosition());

                timer = 0;
            }

        }
        if (Input.GetMouseButtonUp(0))
        {


                newLine = new GameObject();
      
                linePoints.Add(GetMousePosition());
    
             
                lineREnder = newLine.AddComponent<LineRenderer>();
                lineREnder = newLine.GetComponent<LineRenderer>();
                lineREnder.material = new Material(Shader.Find("Sprite/Default"));
                lineREnder.startWidth = 1f;
                lineREnder.endWidth = 1f;

               
                

             
             //   lineREnder.SetPosition(0, linePoints[0]);
             //   lineREnder.SetPosition(1, linePoints[1]);
            //    endPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //      lineREnder.SetPosition(1, endPos);
            lineREnder.positionCount = linePoints.Count;
            lineREnder.SetPositions(linePoints.ToArray());

            linePoints.Clear();
             
            }

        }

   

        private Vector3 GetMousePosition()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            return ray_.origin + ray_.direction * 10;
        }
    } 