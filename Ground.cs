using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Pfoot;
    public GameObject Pfootorpoint;
    public AudioSource FootGround;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FootGround.Play();
            Pfoot.transform.position = Pfootorpoint.transform.position;
            
        }



        
    }
}
