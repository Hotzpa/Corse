using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class End_Game : MonoBehaviour
{
    public Player playerScript;

    public TMP_Text EndText;
    public TMP_Text FinalScoreText;

    public GameObject EndGameButton;
    public GameObject ResetGameButton;

    public GameObject MianCamra;
    public GameObject EndGameCamra;

    public GameObject Player;


    private void Start()
    {
        EndText.text = "";
        FinalScoreText.text = "";

        EndGameButton.SetActive(false);
        ResetGameButton.SetActive(false);

        MianCamra.SetActive(true);
        EndGameCamra.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (playerScript.BallsCount == 0)
        {
            EndText.text = "No More Balls!";

            EndGameButton.SetActive(true);
            ResetGameButton.SetActive(true);

        }
    }


    public void RestTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void EndTheGame()
    {
        EndGameCamra.SetActive(true);

        MianCamra.SetActive(false);     
        EndGameButton.SetActive(false);
        ResetGameButton.SetActive(false);

        Player.SetActive(false);

        playerScript.BallsText.text = "";
        playerScript.ScoreText.text = "";

        FinalScoreText.text = "Your final score: " + playerScript.OverAllScore.ToString();


    }
}
