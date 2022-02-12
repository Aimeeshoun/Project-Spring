using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAnimation : MonoBehaviour
{

    public GameObject drone;
    public Animator animator;
    public bool  isClicked;
    public bool  isNotClicked;
    
    void Start()
    {
        isClicked = false;
     
        animator = drone.GetComponent<Animator>(); 
        isClicked = animator.GetBool("is clicked");
        isNotClicked = animator.GetBool("is not clicked");
    }

    private void OnMouseDown()
    {
        StartCoroutine(AnimateDrone());
    }

    public IEnumerator AnimateDrone()
    {
        isClicked = true;
        yield return new WaitForSeconds(4f);
       
        isNotClicked = true;
    }

}
