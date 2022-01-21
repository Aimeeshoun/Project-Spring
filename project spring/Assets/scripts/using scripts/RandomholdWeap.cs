using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomholdWeap : MonoBehaviour
{

    private int index3;
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

    /// <summary>
    /// //
    /// </summary>
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

    // Start is called before the first frame update
    void Start()
    {
     

        SetRandomTime();
        time = 0;

        SelectedWeapon();
        SelectedCharacter();

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
                        SelectedCharacter();
                        StartCoroutine(SpawnWeapon()); 
                        SpawnWeapon();
                        time = 0;

                        // timer = 1 / maxSpawnPerSecond;
                    }
                }


            }
        }
    }


        public void SelectedCharacter()
    {

       
      //index = Random.Range(0, CharacterList.Length);
      //currentCharacter_ = CharacterList[index];
 
    }


    public void SelectedWeapon()
    {
        index4 = Random.Range(0, weaponList.Length);
        currentWeapon = weaponList[index4];
    
    }


    public IEnumerator SpawnWeapon()
    {

    


        SelectedWeapon();
        SelectedCharacter();
        // spawning = true;

        currentWeapon = Instantiate(currentWeapon, currentCharacter_.transform.position, currentCharacter_.transform.rotation) as GameObject;
        currentWeapon.transform.SetParent(currentCharacter_.transform);

        yield return new WaitForSeconds(spawnRate);
        spawning = false;
        //selectRandomObjects();


        
       


    }


    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);

    }
}
