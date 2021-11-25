using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject SpawnedAnt;
    private int spawnTimer;
    public GameObject Spawnlocation;
    static public int SpawnValue = 15;
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += SpawnValue;

        if(spawnTimer >= 5000)
        {
            Instantiate(SpawnedAnt, Spawnlocation.transform);
            spawnTimer = 0;
            
        }

 
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ant")
        {
            spawnTimer = 0;
            SpawnValue = 0;
        
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ant")
        {
            spawnTimer = 0;
            SpawnValue = 20;
            

        }
    }
}
