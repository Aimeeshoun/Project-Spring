using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlesystem : MonoBehaviour
{

    public ParticleSystem particleSystem_;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EmitParticles()
    {
        particleSystem_.Emit(300);
    }
}
