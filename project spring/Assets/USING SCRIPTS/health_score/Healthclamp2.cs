using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthclamp2 : MonoBehaviour
{


    public int _maxHealth;
    public Image healthBar_;
    public IntData _currentHealth;
    public killfuzzy grabIntData_;
    public GameObject fuzzies;
    public GameObject Textbar_;
    public Text text;
    public GameObject healthobj_;
    public HealthtonextLevel healthtoNextLevel;
    public int currentHealth__;

    public void Start()
    {
        healthBar_ = healthBar_.GetComponent<Image>();
        Textbar_ = GameObject.FindGameObjectWithTag("text score 2");
        text = Textbar_.GetComponent<Text>();
        healthobj_ = GameObject.FindGameObjectWithTag("health obj");
        healthtoNextLevel = healthobj_.GetComponent<HealthtonextLevel>();

    }

    public void Update()
    {
       fuzzies = GameObject.FindGameObjectWithTag("Fuzzy");
        if (!fuzzies == null)
        {
            grabIntData_ = fuzzies.GetComponent<killfuzzy>();
            _currentHealth = grabIntData_.alienScore;
            _maxHealth = healthtoNextLevel.valueOfDead;
            currentHealth__ = _currentHealth.value;

        }
          
    }

    public void AddTotHealth2()
    {
        if (currentHealth__ < 0)
            currentHealth__ = 0;

        if (currentHealth__ > _maxHealth)
            currentHealth__ = _maxHealth;

        if (currentHealth__ < _maxHealth)
            currentHealth__ = _maxHealth;
    }
    public void UpdateImage(IntData data)

    {
        healthBar_.fillAmount = data.value * 1f / _maxHealth;
    }
}

