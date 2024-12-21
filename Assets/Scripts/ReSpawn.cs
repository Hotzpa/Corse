using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    public Player PlayerScript;


    public GameObject Player;

    private Vector3 OriginPoint = new Vector3(0.25f, 10.312f, 5.05f);

    private void OnTriggerEnter(Collider other)
    {
        ReSpawnPlayer();
    }

    public void ReSpawnPlayer()
    {
        Player.transform.position = OriginPoint;
        PlayerScript.Move = true;
        PlayerScript.BallsCount--;

        PlayerScript.SetCountText();
    }
}
