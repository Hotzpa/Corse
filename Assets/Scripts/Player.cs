using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
   

    private Rigidbody rb;

    public Vector3 PlayerSpeed;
    public Vector3 FallSpeed;
    private Vector3 NoVolocity = new Vector3(0, 0, 0);
   

    public bool Move = true;

    public int OverAllScore = 0;
    public int BallsCount = 3;

    public TMP_Text ScoreText;
    public TMP_Text BallsText;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

        ScoreText.text = "Score: " + OverAllScore;
        BallsText.text = "Balls: " + BallsCount;
    }

    private void Update()
    {
        MoveScript();
        Release();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("StopPoint"))
        PlayerSpeed = -PlayerSpeed;
        
    }

    private void MoveScript()
    {
        if(Move == true)
        {
            rb.velocity = PlayerSpeed;
            rb.useGravity = false;
        }
        

        if (Input.GetKeyDown(KeyCode.F))
        {
            Move = false;
        }
                 

    }

    private void Release()
    {
        if (Move == false && BallsCount >0)
        {
            rb.AddForce(NoVolocity);
            rb.useGravity = true;
        }
            
    }

    public void SetCountText()
    {
        ScoreText.text = "Score: " + OverAllScore.ToString();
        BallsText.text = "Balls: " + BallsCount.ToString();
    }

}
