using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foot : MonoBehaviour
{
    public GameObject Screen1, Screen2, Screen3;
    public GameObject PFoot;
    public GameObject PFootOrPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "stopInput")
        {
            Screen1.SetActive(false);
            Screen2.SetActive(false);
            Screen3.SetActive(false);
        }
        else if (collision.gameObject.tag == "Ground")
        {
            Screen1.SetActive(true);
            Screen2.SetActive(true);
            Screen3.SetActive(true);
        }
    }




}
