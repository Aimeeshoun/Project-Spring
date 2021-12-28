using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciateObj : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject gameObject2;
    public GameObject gameObject3;

    public void Awake()
    {
        if (this.gameObject == false)
        {

            Instantiate(gameObject2, new Vector2(gameObject3.gameObject.transform.position.x, gameObject3.gameObject.transform.position.y), Quaternion.identity);

        }
          
    }
}
