using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomholdWeap : MonoBehaviour
{

    public int spawnAmount;
    public float spawnRate;
    private bool spawning;
    public float maxTime;
    public float minTime;
    private float spawnTime;
    private float time;
    public GameObject currentWeaponTARGET;
    private int index2;
    public float maxSpawnPerSecond;
    private float timer;
    public SpawnRandomPoints characterSel;
    public SelectedObjects selectedObjects;
    public GameObject[] weaponList;
    public GameObject[] CharacterList;
    public GameObject currentWeapon;
    private int index;
    private int index4;
    public GameObject gameobject_;
    public GameObject currentCharacter_;
    public ID currentcharholder2;

    void Start()
    {
     
        SetRandomTime();
        time = 0;
        SelectedWeapon();
        characterSel = GameObject.Find("Enemy Spawner").GetComponent<SpawnRandomPoints>();
        selectedObjects= GameObject.Find("character spawner sel").GetComponent<SelectedObjects>();
    }

    void FixedUpdate()
    {
        currentCharacter_ = characterSel.currentChar;
     //    currentcharholder2 = selectedObjects.currentwepholder2;

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
   
                        SelectedWeapon();
                        StartCoroutine(SpawnWeapon()); 
                        SpawnWeapon();
                        time = 0;

                    }
                }
            }
        }
    }

    public void SelectedWeapon()
    {
        index4 = Random.Range(0, weaponList.Length);
        currentWeapon = weaponList[index4];
    
    }

    public IEnumerator SpawnWeapon()
    {
        SelectedWeapon();
        currentWeapon = Instantiate(currentWeapon, currentCharacter_.transform.position, currentCharacter_.transform.rotation) as GameObject;
        currentWeapon.transform.SetParent(currentCharacter_.transform);
        yield return new WaitForSeconds(spawnRate);
        spawning = false;
    }

    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }
}
