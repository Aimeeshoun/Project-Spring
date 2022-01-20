using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthclamp2 : MonoBehaviour
{


    public int _maxHealth;


    public float healthBarLength;
    public Image healthBar_;
    public IntData _currentHealth;

    public int valueOfDead = 30;
    public killfuzzy grabIntData_;
    public GameObject fuzzies;
   /// public GameObject fuzzy_;
   
  //  public GameObject alienAlive_;
    public GameObject Textbar_;
    public Text text;

    public GameObject healthobj_;

    public HealthtonextLevel healthtoNextLevel;
    public int currentHealth__;

    // Use this for initialization
    public void Start()
    {
        healthBar_ = healthBar_.GetComponent<Image>();

        //    healthBarLength = Screen.width / 2;
        Textbar_ = GameObject.FindGameObjectWithTag("text score 2");
        text = Textbar_.GetComponent<Text>();

        healthobj_ = GameObject.FindGameObjectWithTag("health obj");
        healthtoNextLevel = healthobj_.GetComponent<HealthtonextLevel>();


    }

    public void Update()
    {

        fuzzies = GameObject.FindGameObjectWithTag("Fuzzy");
            grabIntData_ = fuzzies.GetComponent<killfuzzy>();
            _currentHealth = grabIntData_.alienScore;
            _maxHealth = healthtoNextLevel.valueOfAlienDead;
            currentHealth__ = _currentHealth.value;
        healthBar_.fillAmount = currentHealth__ * 1f / _maxHealth;

    }


    public void AddTotHealth2()
    {

        //     currentHealth__ += 1;

        if (currentHealth__ < 0)
            currentHealth__ = 0;

        if (currentHealth__ > _maxHealth)
            currentHealth__ = _maxHealth;

        if (currentHealth__ < _maxHealth)
            currentHealth__ = _maxHealth;



    }
}

