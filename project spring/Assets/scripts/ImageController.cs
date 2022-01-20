using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
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

