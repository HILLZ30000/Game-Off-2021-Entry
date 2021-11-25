using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudTeleport : MonoBehaviour
{
    public GameObject CloudOrPoint;
    public GameObject Cloud;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "cloud")
        {
            Cloud.transform.position = CloudOrPoint.transform.position;
        }
    }
}
