using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialAnimation : MonoBehaviour
{
    public GameObject frame1;
    public GameObject frame2;
    public static int frameCounter;
    // Start is called before the first frame update
    void Start()
    {
        frameCounter = 0;
        frame1.SetActive(false);
        frame2.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

        frameCounter++;

        if (frameCounter == 125)
        {
            frame1.SetActive(true);
            frame2.SetActive(false);
        }
        else if (frameCounter == 250)
        {
            frame1.SetActive(false);
            frame2.SetActive(true);
        }
        else if (frameCounter == 282)
        {
            frameCounter = 0;
        }
        
        
        
        
        
        
        
    }
}
