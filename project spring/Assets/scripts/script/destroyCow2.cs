using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyCow2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }





    private void OnTriggerEnter(Collider other)
    {

    if(other.tag == "Fuzzy")
    {
        // scorevalue.value += -1;
        //  other.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
    }
    


    
}

}
