using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBlock : MonoBehaviour
{
    public Player PlayerScript;

    public GameObject Player;

    public ParticleSystem SpwanEffect;

    public Player player;

    public int ScoreAdd;

    private Vector3 OriginPoint = new Vector3(0.25f, 10.312f, 5.05f);


    private void OnTriggerEnter(Collider other)
    {
        player.OverAllScore += ScoreAdd;

        SpwanEffect.Play(true);

        Player.transform.position = OriginPoint;
        PlayerScript.Move = true;
        PlayerScript.BallsCount--;

        player.SetCountText();
    }
}
