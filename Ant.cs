using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : MonoBehaviour
{
    private Animator AntAnimation;
    static bool IsCollected;
    private Rigidbody2D antRB;
    static public float AntSpeed;

    public GameObject BPOP;
    public GameObject antBack;
    public GameObject BPItem;
    
    public GameObject DropPoint;
    private int AntScore = 500;
    public AudioSource AntDeath;

    private float AntStopSpeed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        BPItem = GameObject.FindGameObjectWithTag("basket");
        BPOP = GameObject.FindGameObjectWithTag("PBLocation");
        AntDeath = GameObject.Find("EnemyDeathSound").GetComponent<AudioSource>();
        antRB = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {

        AntMovement();


        if (BPItem.transform.position == BPOP.transform.position)
        {
            IsCollected = false;
        }
        else if (BPItem.transform.position == antBack.transform.position)
        {
            IsCollected = true;

        }


        
    }
    void AntMovement()
    {
        if (IsCollected == false)
        {
            antRB.velocity = new Vector2(-AntSpeed * Time.fixedDeltaTime, antRB.velocity.y);
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        else if (IsCollected == true)
        {
            antRB.velocity = new Vector2(AntSpeed * Time.fixedDeltaTime, antRB.velocity.y);
            transform.localEulerAngles = new Vector3(0, 180, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "basket")
        {

            BPItem.transform.position = antBack.transform.position;
            BPItem.transform.SetParent(antBack.transform);
            IsCollected = true;



        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && BPItem.transform.position == antBack.transform.position)
        {
            BPItem.transform.position = DropPoint.transform.position;
            BPItem.transform.SetParent(p: null);
            antRB.velocity = new Vector2(AntStopSpeed * Time.fixedDeltaTime, antRB.velocity.y);
            IsCollected = false;
            AntDeath.Play();
            ScoreSystem.Score += AntScore;

            Destroy(gameObject);

        }
        else if (collision.gameObject.tag == "Player")
        {
            antRB.velocity = new Vector2(AntStopSpeed * Time.fixedDeltaTime, antRB.velocity.y);
            AntDeath.Play();
            ScoreSystem.Score += AntScore;

            Destroy(gameObject);

            
        }
        
        
    }



}
