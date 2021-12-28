using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardDisplay : MonoBehaviour
{
   
    
    
    public CollectionSO card;
    public Image artworkImage;
    public Text nameText;

  
   
    void Start()
    {
        nameText.text = card.name;
  //     artworkImage.sprite = CollectionSO.artwork;
    }

    // Update is called once per frame
    void Update()
    { 

        
    }
}
