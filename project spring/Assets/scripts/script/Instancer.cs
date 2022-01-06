using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancer : MonoBehaviour
{ 
 
    public GameObject bullet;
 


    public float BulletSpeed;
  
    public AudioClip GunshotSound;


    // Use this for initialization
    void Start()
{

}

// Update is called once per frame
void Update()
{
 
        Fire();



}

void Fire()
{
        bullet = Instantiate(bullet, this.gameObject.transform.position, this.gameObject.transform.rotation);
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * BulletSpeed);
    }
}