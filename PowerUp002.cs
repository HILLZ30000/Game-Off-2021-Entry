using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp002 : MonoBehaviour
{
    private int TimeLimit;
    public GameObject basket;
    public GameObject basketLocation;

    // Start is called before the first frame update
    void Start()
    {
        basket = GameObject.FindGameObjectWithTag("basket");
        basketLocation = GameObject.FindGameObjectWithTag("PBLocation");
        TimeLimit = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TimeLimit++;

        if (TimeLimit >= 240)
        {
           Destroy(gameObject);
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            basket.transform.SetParent(p: null);
            basket.transform.position = basketLocation.transform.position;
        }
    }



}
