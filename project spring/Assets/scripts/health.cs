using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class health : MonoBehaviour

{

    public float maxHealth = 100f;
    public float currentHealth;
    public event Action<float> OnHealthPctChanged = delegate { };


    private void OnEnable()
    {
        currentHealth = maxHealth;
    }


    public void ModifyHealth(int amount)
    {
        currentHealth += amount;
        float currentHealthPct = (float)currentHealth / (float)maxHealth;
        OnHealthPctChanged(currentHealthPct);
    }

    void Ontriggerenter(Collider other)
    {
        ModifyHealth(-10);
    }
}
