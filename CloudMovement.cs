using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    private Rigidbody2D cloudRB;
    private float CloudSpeed = 400f;

    // Start is called before the first frame update
    void Start()
    {
        cloudRB = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        cloudRB.velocity = new Vector2(-CloudSpeed * Time.fixedDeltaTime, cloudRB.velocity.y);
    }
}
