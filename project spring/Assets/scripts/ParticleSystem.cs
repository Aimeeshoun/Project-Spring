using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystem : MonoBehaviour

{
    public ParticleSystem particleSystemObj;

    public void RunParticleSystem()
    {
        particleSystemObj.Emit(100);
    }
}

