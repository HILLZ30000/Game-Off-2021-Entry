using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static int Score;
    public Text ScoreText;
    public GameObject SP2, SP3, SP4, SP5, SP6, SP7, SP8, SP9, SP10, SP11, SP12, SP13, SP14, SP15, SP16, SP17, SP18, SP19, SP20, SP21, SP22, SP23, SP24, SP25, SP26, SP27, SP28, SP29, SP30, SP31, SP32, SP33, SP34;
    public GameObject SP35, SP36, SP37, SP38, SP39, SP40, SP41, SP42, SP43, SP44, SP45, SP46, SP47, SP48, SP49, SP50, SP51, SP52, SP53, SP54, SP55, SP56, SP57;
    

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Score.ToString();
        if (Score <= 5000)
        {
            Ant.AntSpeed = 300f;
            SP2.SetActive(true);
            SP3.SetActive(true);
        }
        else if (Score >= 5000 && Score <= 10000)
        {
            Ant.AntSpeed = 600f;
            SP4.SetActive(true);
            SP5.SetActive(true);
            SP6.SetActive(true);
            SP7.SetActive(true);
            SP8.SetActive(true);
            SP9.SetActive(true);
            
            
        }
        else if (Score >= 10000 && Score <= 20000)
        {
            Ant.AntSpeed = 900f;
            SP10.SetActive(true);
            SP11.SetActive(true);
            SP12.SetActive(true);
            SP13.SetActive(true);
            SP14.SetActive(true);
            SP15.SetActive(true);
            SP16.SetActive(true);
            SP17.SetActive(true);
            SP18.SetActive(true);

        }
        else if (Score >= 20000 && Score <= 25000)
        {
            Ant.AntSpeed = 1500f;
            SP19.SetActive(true);
            SP20.SetActive(true);
            SP21.SetActive(true);
            SP22.SetActive(true);
            SP23.SetActive(true);
            SP24.SetActive(true);
            SP25.SetActive(true);
            SP26.SetActive(true);
            SP27.SetActive(true);
            SP28.SetActive(true);
            SP29.SetActive(true);
            SP30.SetActive(true);
            SP31.SetActive(true);
            SP32.SetActive(true);
            SP33.SetActive(true);


        }
        else if (Score >= 25000)
        {
            Ant.AntSpeed = 2400f;
            SP34.SetActive(true);
            SP35.SetActive(true);
            SP36.SetActive(true);
            SP37.SetActive(true);
            SP38.SetActive(true);
            SP39.SetActive(true);
            SP40.SetActive(true);
            SP41.SetActive(true);
            SP42.SetActive(true);
            SP43.SetActive(true);
            SP44.SetActive(true);
            SP45.SetActive(true);
            SP46.SetActive(true);
            SP47.SetActive(true);
            SP48.SetActive(true);
            SP49.SetActive(true);
            SP50.SetActive(true);
            SP51.SetActive(true);
            SP52.SetActive(true);
            SP53.SetActive(true);
            SP54.SetActive(true);
            SP55.SetActive(true);
            SP56.SetActive(true);
            SP57.SetActive(true);

        }
        if (Basket.GO >= 1)
        {
            SP2.SetActive(false);
            SP3.SetActive(false);
            SP4.SetActive(false);
            SP5.SetActive(false);
            SP6.SetActive(false);
            SP7.SetActive(false);
            SP8.SetActive(false);
            SP9.SetActive(false);
            SP10.SetActive(false);
            SP11.SetActive(false);
            SP12.SetActive(false);
            SP13.SetActive(false);
            SP14.SetActive(false);
            SP15.SetActive(false);
            SP16.SetActive(false);
            SP17.SetActive(false);
            SP18.SetActive(false);
            SP19.SetActive(false);
            SP20.SetActive(false);
            SP21.SetActive(false);
            SP22.SetActive(false);
            SP23.SetActive(false);
            SP24.SetActive(false);
            SP25.SetActive(false);
            SP26.SetActive(false);
            SP27.SetActive(false);
            SP28.SetActive(false);
            SP29.SetActive(false);
            SP30.SetActive(false);
            SP31.SetActive(false);
            SP32.SetActive(false);
            SP33.SetActive(false);
            SP34.SetActive(false);
            SP35.SetActive(false);
            SP36.SetActive(false);
            SP37.SetActive(false);
            SP38.SetActive(false);
            SP39.SetActive(false);
            SP40.SetActive(false);
            SP41.SetActive(false);
            SP42.SetActive(false);
            SP43.SetActive(false);
            SP44.SetActive(false);
            SP45.SetActive(false);
            SP46.SetActive(false);
            SP47.SetActive(false);
            SP48.SetActive(false);
            SP49.SetActive(false);
            SP50.SetActive(false);
            SP51.SetActive(false);
            SP52.SetActive(false);
            SP53.SetActive(false);
            SP54.SetActive(false);
            SP55.SetActive(false);
            SP56.SetActive(false);
            SP57.SetActive(false);














        }
        
        
    }
}
