using UnityEngine;

public class particleSystem : MonoBehaviour
{
    public ParticleSystem Particles;
    public float value = 3f;

    public void Awake()


    {

            Particles.Emit(540);

    }

}