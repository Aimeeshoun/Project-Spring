using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthpowerup : MonoBehaviour
{
    public Transform position_;
    public Vector3 _position;
    public GameObject particle;
    public ParticleSystem particle_;



    public void Start()
    {
        position_ = this.gameObject.GetComponent<Transform>();
        particle_ = particle.GetComponent<ParticleSystem>();
    }
    public void Update()
    {
        _position = position_.position;
    }


    private void OnMouseDown()
    {

        particle_.transform.position = _position;
        particle_.Emit(25);
        Destroy (this.gameObject,1.5f);
        particle_.Emit(25);
    }
}
