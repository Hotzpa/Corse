using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlatform : MonoBehaviour
{

    public GameObject SpawnPoint;

    private void OnCollisionEnter(Collision collision)
    {
       collision.transform.position = SpawnPoint.transform.position;
    }

}
