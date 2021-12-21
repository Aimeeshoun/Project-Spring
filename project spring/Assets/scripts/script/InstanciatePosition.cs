using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciatePosition : MonoBehaviour
{


    public ParticleSystem particleSystem;
    public GameObject gameObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ReplaceCoinWithSys(GameObject gameObject, GameObject particleSystem)
    {
        Instantiate(particleSystem, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
        
    }
}
