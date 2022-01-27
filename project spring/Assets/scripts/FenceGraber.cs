using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceGraber : MonoBehaviour
{

    public int x;

    public FenseMaker2 fenseMaker_;
    public GameObject scriptHolder;
    public GameObject scriptHolder2;
    public Vector3 linePoint3;
    public Vector3 linePoint4;
    public GameObject newLine;
    public LineRenderer lineREnder;

    public int Timer;
    public int Timer2;

    public List<Vector3> positions_;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scriptHolder = GameObject.FindGameObjectWithTag("line");
      fenseMaker_ = scriptHolder.GetComponent<FenseMaker2>();
        linePoint3 = fenseMaker_.linePoint;
        linePoint4 = fenseMaker_.linePoint2;
        scriptHolder2 = GameObject.FindGameObjectWithTag("line2");
        lineREnder = scriptHolder2.GetComponent<LineRenderer>();
        lineREnder.SetPosition(0, linePoint3);
        lineREnder.SetPosition(1, linePoint4);



        lineREnder.material = new Material(Shader.Find("Sprite/Default"));
        lineREnder.startWidth = 1f;
        lineREnder.endWidth = 8f;

  



    }

    }
