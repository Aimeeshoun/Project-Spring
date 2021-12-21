using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciatePosition : MonoBehaviour
{


  
    public GameObject gameObject2;
    public GameObject gameObject3;
    
    void Update()
    {
        if (this.gameObject == false)
            {
            Instantiate(gameObject2, new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y), Quaternion.identity);
        }
           
        
    }

    // Update is called once per frame

  
}
