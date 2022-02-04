using UnityEngine;
using UnityEngine.UI;

public class ImageController : MonoBehaviour


{
    private Image img;

    void Awake()

    {
        img = GetComponent<Image>();
    }

    public void UpdateImage(IntData data)

    {
        img.fillAmount = data.value;
    }

}

