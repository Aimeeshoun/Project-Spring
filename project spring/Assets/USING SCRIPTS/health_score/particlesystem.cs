using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlesystem : MonoBehaviour
{

    public ParticleSystem particleSystem_;
    

    public void EmitParticles()
    {
        particleSystem_.Emit(300);
    }
}
