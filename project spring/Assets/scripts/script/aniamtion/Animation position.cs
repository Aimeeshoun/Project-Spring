using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationposition : MonoBehaviour
{


    public GameObject Ring;
    public Animator _Animation;

  
    private GameObject Target_;
    // Start is called before the first frame update
    void Start()
    {
        Ring = GameObject.FindGameObjectWithTag("Ring");
        _Animation = Ring.GetComponentInChildren<Animator>();
      
    }

    // Update is called once per frame
    void Update()
    {
        Target_ = this.gameObject;

    }

    private void OnDestroy()
    {
        Ring = Instantiate(Ring, Target_.transform.position, Target_.transform.rotation) as GameObject;
        Ring.transform.parent = gameObject.transform;
        _Animation.Play("ring animation");
    }
}
