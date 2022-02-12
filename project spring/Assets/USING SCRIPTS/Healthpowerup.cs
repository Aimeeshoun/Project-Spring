using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(IntData))]
public class Healthpowerup : MonoBehaviour
{
    public Transform position_;
    public Vector3 _position;
    public Quaternion _rotation;
  //  public GameObject particle;
    public ParticleSystem particle_;
    public IntData data;
   public int Timer = 0;
    public int Timer2 = 0;
    public int power = 5;
    public void Start()
    {
        position_ = this.gameObject.GetComponent<Transform>();
        particle_ = gameObject.GetComponent<ParticleSystem>();
       
    }

    public void Awake()
    {
        _position = position_.position;
        _rotation = position_.rotation;
        data = GetComponent<IntData>();
    }
    public void Update()
    {
    
    }


    private void OnMouseDown()
    {
        Timer = 1;
        



        if (Timer == 1)
        {
            UpdateImage();
            particle_ = Instantiate(particle_, _position, _rotation);
            //  particle = Instantiate(particle, _position, _rotation);
            particle_.transform.position = _position;
            particle_.Emit(500);
          //  Timer2 = 1;
            Destroy(this.gameObject);
            Timer = 0;

            

            
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
