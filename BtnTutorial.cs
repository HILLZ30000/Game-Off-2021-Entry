using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnTutorial : MonoBehaviour
{
    public GameObject TutAnim;
    public GameObject TutCon;
    private bool controlScreen;
    // Start is called before the first frame update



    private void Start()
    {
        controlScreen = false;
        
    }



    public void tutAnim()
    {
        if (controlScreen == false)
        {
            tutorialAnimation.frameCounter = 0;
            controlScreen = true;
            TutCon.SetActive(true);
            TutAnim.SetActive(true);
            
        }
        else if (controlScreen == true)
        {
            tutorialAnimation.frameCounter = 0;
            TutAnim.SetActive(false);
            controlScreen = false;
            TutCon.SetActive(false);
        }


        
    }




}
