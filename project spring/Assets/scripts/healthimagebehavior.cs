using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]

public class healthimagebehavior : MonoBehaviour
{


public class ImageBehavior : MonoBehaviour
{
    private Image healthImage;
    public FloatDataScript health, maxhealth;
    void Start()
    {
        healthImage = GetComponent<Image>();

    }


    void Update()
    {
        healthImage.fillAmount = health.value / maxhealth.value;
    }
}
        
    }
