using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthClamp : MonoBehaviour

{
  
    public int _maxHealth;
    

    public float healthBarLength;
    public Image healthBar_;
    public IntData _currentHealth;

    public int valueOfDead = 30;
    public InstanciteDeadCow2 grabIntData_;
    public GameObject cowAlive_;
    public GameObject Textbar_;
    public Text text;

    public GameObject healthobj_;

    public HealthtoGameOver healthtoGameOver;
    public int currentHealth__;

    // Use this for initialization
    void Start()
    {
        healthBar_ = healthBar_.GetComponent<Image>();
        
    //    healthBarLength = Screen.width / 2;
        Textbar_ = GameObject.FindGameObjectWithTag("Text score");
        text = Textbar_.GetComponent<Text>();

        healthobj_ = healthobj_ = GameObject.FindGameObjectWithTag("health obj");
        healthtoGameOver = healthobj_.GetComponent<HealthtoGameOver>();
      


    }

    private void Update()
    {

        cowAlive_ = GameObject.FindGameObjectWithTag("COW ALIVE");
        grabIntData_ = cowAlive_.GetComponent<InstanciteDeadCow2>();
        _currentHealth = grabIntData_.score;
        _maxHealth = healthtoGameOver.valueOfDead;
        currentHealth__ = _currentHealth.value;
    
        healthBar_.fillAmount = currentHealth__ * 1f / _maxHealth;
    }




    public void AddTotHealth()
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

