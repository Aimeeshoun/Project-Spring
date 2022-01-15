using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstanciteDeadCow2 : MonoBehaviour
{

    public GameObject deadcow;
    public GameObject deadcow2;
    public GameObject this_gamObj;
    public GameObject this_gamObj2;

    private bool spawning;
    private bool spawning2;
    public float spawnRate;
    public Transform position_;
    public Vector3 _postion;
    public Quaternion _rotation;

    public Text text;
    public string text_;
    public IntData score;
    public Image scorebar;
    public GameObject scorebar_;
    public GameObject Textbar_;
    public void Start()
    {
        scorebar_ = GameObject.FindGameObjectWithTag("Score bar");
        Textbar_ = GameObject.FindGameObjectWithTag("Text score");
        position_ = this_gamObj2.GetComponent<Transform>();
        scorebar = scorebar_.GetComponent<Image>();
        text = Textbar_.GetComponent<Text>();


    }
    // Update is called once per frame
    public void Update()
    {

        _postion = position_.position;
        _rotation = position_.rotation;

        text.text = score.value.ToString();
        scorebar.fillAmount = score.value;

    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Fuzzy")
        {

            StartCoroutine(Killcow());
            Killcow();
            this_gamObj.SetActive(false);
            score.value += 1;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Fuzzy")
        {

            // Destroy(deadcow2);
        }
    }



    public IEnumerator Killcow()
    {
        deadcow = Instantiate(deadcow, _postion, _rotation) as GameObject;
        deadcow.transform.parent = gameObject.transform;
        Destroy(deadcow, 4f);
        yield return new WaitForSeconds(spawnRate);
        spawning = false;
        StartCoroutine(Killcow2());
        Killcow2();

    }
    public IEnumerator Killcow2()
    {
        deadcow2 = Instantiate(deadcow2, this_gamObj.transform.position, this_gamObj.transform.rotation) as GameObject;
        deadcow2.transform.parent = gameObject.transform;

        yield return new WaitForSeconds(spawnRate);
        spawning2 = false;

    }

}