using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
[CreateAssetMenu]

public class FloatDataScript : ScriptableObject
{
    public float value;
    public UnityEvent setValueEvent, updateValueEvent, lessThanZeroEvent, lessThanZeroEvent2;

  
    public void SetValue(float number)
    {
        value = number;
        setValueEvent.Invoke();
    }

    public void UpdateValue(float number)
    {
        value += number;
        updateValueEvent.Invoke();
    }

    public void SetImageFillAmount(Image img)
    {
        if (value >= 0 || value <= 1)
        {
            img.fillAmount = value;
        }

        if (value <= 0)
        {
            lessThanZeroEvent.Invoke();
            value = 0;
        }

        if (value >= 1)
        {
            value = 1;
        }
    }
  //  public void AddScore(IntData score)
   // {
  //      if (value <= 0)
  //      {
     //       lessThanZeroEvent2.Invoke();

   //     }
   // }
}
