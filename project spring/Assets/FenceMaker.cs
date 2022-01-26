using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceMaker : MonoBehaviour
{

    public Vector3 linePoint;
    public float timer=0;
    public float timer2=0;
   // public float timerdelay;

    public GameObject currentLine;
    public LineRenderer lineREnder;
    public float lineWidth=5;
    public Material mat;
    public GameObject linePrefab;
    //   public BoxCollider boxCollider_;

    public Ray ray_;
    public Ray ray2_;


    public Vector3 startPos;
    public Vector3 endPos;

    public Camera cam;
    public List<Vector3> positions_;

    // Start is called before the first frame update
    public void Start()
    {
        cam = Camera.main;
      //  timer = timerdelay;

    }

    public void Awake()
    {
   

    }

    // Update is called once per frame
    public void Update()

    {
        
        if (Input.GetMouseButtonDown(0))
        { if(lineREnder == null)
            {
                lineREnder = gameObject.AddComponent<LineRenderer>();
            }

            lineREnder.positionCount = 2;
            startPos = cam.ScreenToWorldPoint(Input.mousePosition);
            lineREnder.SetPosition(0, startPos);


                timer = 1;
          //   timer += Time.deltaTime;
              if (timer == 1)
              {
           //     CreateLine();

            //    GetMousePosition();
               
                timer = 0;
              }
          

          //  Debug.DrawRay(Camera.main.ScreenToWorldPoint(Input.mousePosition), GetMousePosition(), Color.yellow);
          // timer += Time.deltaTime;
          //  if (timer == 1)
          //  {
       
          //  }
        }

        if (Input.GetMouseButton(0))
        {
            timer2 = 1;
            //  timer += Time.deltaTime;
            if (timer2 == 1)
            {

               
             //   GetMousePosition2();

                timer2 = 0;
            }
        }

            if (Input.GetMouseButtonUp(0))
        {

            endPos = cam.ScreenToWorldPoint(Input.mousePosition);
            lineREnder.SetPosition(1, endPos);
            CreateLine();
         //   lineREnder.enabled = false;
            

         
        //    currentLine = new GameObject();


         

      //      lineREnder.positionCount = linePoints.Count;
      //      lineREnder.SetPositions(linePoints.ToArray());

 
            //    Debug.Log(linePoints);
             //   linePoints.Clear();
            }
        }



    public Vector3 GetMousePosition()
    {
        ray_ = Camera.main.ScreenPointToRay(Input.mousePosition);
        return ray_.origin + ray_.direction * 10;
    }
    public Vector3 GetMousePosition2()
    {
        ray2_ = Camera.main.ScreenPointToRay(Input.mousePosition);
        return ray2_.origin + ray2_.direction * 10;
    }

    public void CreateLine()
    {
        currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity);
        lineREnder = currentLine.AddComponent<LineRenderer>();

        lineREnder.material = mat;
        lineREnder.startWidth = lineWidth;
        lineREnder.endWidth = lineWidth;

        positions_.Clear();
        lineREnder.SetPosition(0, positions_[0]);
        lineREnder.SetPosition(1, positions_[1]);
        


        //   boxCollider_ = currentLine.GetComponent<BoxCollider>;

    }

}
