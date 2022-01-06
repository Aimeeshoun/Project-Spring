using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancer : MonoBehaviour
{

    public GameObject bullet;
    public GameObject gun;
    public Transform bulletVelocity;
    private bool spawning;
    public float spawnRate;
    public float BulletSpeed;
    public AudioClip GunshotSound;
    public GameObject newbullet;

    


    public void Fire()
    {



        newbullet = Instantiate(bullet, gun.transform.position, gun.transform.rotation) as  GameObject;

    }

}


