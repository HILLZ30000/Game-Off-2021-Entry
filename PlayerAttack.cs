using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject foot;
    public GameObject footSpawn;
    static public float footSpeed = -4800f;

    public Rigidbody2D footRB;
    public GameObject footOrpoint;
    public GameObject Screen;

    private void Start()
    {
        
        foot.transform.position = footOrpoint.transform.position;

    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {

            
            foot.transform.position = footSpawn.transform.position;
            footRB.velocity = new Vector2(footRB.transform.position.x, footSpeed * Time.fixedDeltaTime);


        }
    }

}
