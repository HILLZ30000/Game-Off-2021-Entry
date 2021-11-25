using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    public GameObject PBLocation;
    public GameObject PB;
    public GameObject GameOverPanel;
    public static int GO;
    public static int finalScore;
  

    // Start is called before the first frame update
    void Start()
    {
        GO = 0;
        PB.transform.position = PBLocation.transform.position;
        GameOverPanel.SetActive(false);
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "gameover")
        {
            GameOverPanel.SetActive(true);
        }

        
    }
    







}
