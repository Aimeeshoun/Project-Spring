using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(IntData))]
public class Healthpowerup : MonoBehaviour
{
    public Transform position_;
    public Vector3 _position;
    public GameObject particle;
    public ParticleSystem particle_;
    public IntData data;
    public int Timer = 0;
    public int Timer2 = 0;
    public int power = 5;
    public void Start()
    {
        position_ = this.gameObject.GetComponent<Transform>();
        particle_ = particle.GetComponent<ParticleSystem>();
    }

    public void Awake()
    {
        data = GetComponent<IntData>();
    }
    public void Update()
    {
        _position = position_.position;
    }


    private void OnMouseDown()
    {
        Timer = 1;
        particle_.Emit(25);



        if (Timer == 1)
        {
            
            particle_.transform.position = _position;
            particle_.Emit(25);
            Timer2 = 1;
            if (Timer2 == 1)
            {

                UpdateImage();
                particle_.Emit(25);
                Timer2 = 0;
                particle_.Emit(25);
                Destroy(this.gameObject, .3f);
            }

            
        }

  
      
    }


    public void UpdateImage()

    {
        if (data.value >= 0)
        {
            data.value -= power;
        }
        if (data.value <= 0)
        {
            data.value = 0;
        }

    }

}
