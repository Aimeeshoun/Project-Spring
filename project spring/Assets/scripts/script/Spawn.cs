using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    // access 
    public IDholder iDholder;
    public IDholder Otheridholder;


    //
    public GameObject _otherID;
    public GameObject _thisID;
    public GameObject _selwepidname;
    public GameObject _selcharidname;
    public IDholder _selWepIdholder;
    public IDholder _selCharIdholder;

    public SelectedObjects currentWeaponSel;
    public SelectedChar _selectedChar;
    public SelectedObjects _selectedObjects;





    //spawn weapon 

    public GameObject[] myWeaponList2;
    public GameObject[] spawnPoints;
    private GameObject currentPoint;
    private int index1;
    public int spawnAmount = 2;
    public float spawnRate = 5;
    private bool spawning;
    public GameObject i;

    public float maxTime = 5;
    public float minTime = 1;
    private float spawnTime;
    private float time;
    private GameObject currentWeapon;
    private int index5;
    public float maxSpawnPerSecond = 2f;
    private float timer;

    //selected weap


    private GameObject currentWeapon2;
    private int index2;
    public GameObject target;
    private float spawnTime2;


    //spawn character

    public GameObject[] myCharacterList;
    // public GameObject[] spawnPoints;         //might not need
    private GameObject currentPoint2;
    private int index3;
    private GameObject currentCharacter;
    private float timer2;
    private int index6;
    //seclected char

    private GameObject currentCharacter2;
    private int index4;

    public GameObject target2;



    //weapon spawn



    // Use this for initialization
    void Start()
    {


        CompareObject();
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");

        //myWeaponList2 = GameObject.FindGameObjectsWithTag("WeaponRandomObj");
        SetRandomTime();

        time = 0;

        // selectRandomObjects();
        // myWeaponList2 = GameObject.FindGameObjectsWithTag("WeaponRandom");
        index2 = Random.Range(0, myWeaponList2.Length);
        currentWeapon2 = myWeaponList2[index2];
        currentWeapon2 = Instantiate(currentWeapon2, target.transform.position, target.transform.rotation) as GameObject;
        currentWeapon2.transform.parent = gameObject.transform;



        // character sel





        // selectRandomObjects();
        // myWeaponList2 = GameObject.FindGameObjectsWithTag("WeaponRandom");
        index4 = Random.Range(0, myCharacterList.Length);
        currentCharacter2 = myCharacterList[index4];
        currentCharacter2 = Instantiate(currentCharacter2, target2.transform.position, target2.transform.rotation) as GameObject;
        currentCharacter2.transform.parent = gameObject.transform;








    }

    // Update is called once per frame
    void FixedUpdate()
    {






       


        _selWepIdholder = currentWeapon.GetComponent<IDholder>();



        


        _selCharIdholder = currentCharacter2.GetComponent<IDholder>();

        CompareObject();


        CompareObject();
        time += Time.deltaTime;
        if (time >= spawnTime)
        {
            if (transform.childCount < spawnAmount && spawning == false)
            {

                if (maxSpawnPerSecond > 0)
                {
                    timer -= Time.deltaTime;

                    if (timer <= 0)
                    {
                        StartCoroutine(SpawnWeapon());
                        SpawnWeapon();
                        SetRandomTime();
                        StartCoroutine(SpawnCharacter());
                        SpawnCharacter();
                        SetRandomTime();

                        time = 0;

                        timer = 1 / maxSpawnPerSecond;
                    }
                }


            }
        }

    }

    public IEnumerator SpawnWeapon()
    {

        selectRandomWeapons();
        index1 = Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[index1];
        currentWeapon = Instantiate(currentWeapon, currentPoint.transform.position, currentPoint.transform.rotation) as GameObject;
        currentWeapon.transform.parent = gameObject.transform;
        Destroy(currentWeapon, 3.5f);
        yield return new WaitForSeconds(spawnRate);
        spawning = false;

    }

    public void selectRandomWeapons()

    {


        index5 = Random.Range(0, myWeaponList2.Length);
        currentWeapon = myWeaponList2[index5];


    }


    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);

    }





    //characer spawn



    public IEnumerator SpawnCharacter()
    {

        selectRandomCharacter();
        index3 = Random.Range(0, spawnPoints.Length);
        currentPoint2 = spawnPoints[index3];
        currentCharacter = Instantiate(currentCharacter, currentPoint.transform.position, currentPoint2.transform.rotation) as GameObject;
        currentCharacter.transform.parent = gameObject.transform;
        Destroy(currentCharacter, 7f);
        yield return new WaitForSeconds(spawnRate);
        spawning = false;

    }

    public void selectRandomCharacter()

    {


        index6 = Random.Range(0, myCharacterList.Length);
        currentCharacter = myCharacterList[index6];

    }




    public void CompareObject()
    {

        iDholder = GetComponent<IDholder>();

        _selWepIdholder = currentWeapon2.GetComponent<IDholder>();

        _selCharIdholder = currentCharacter.GetComponent<IDholder>();



    }
}








