using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Score_Manager : MonoBehaviour
{

    public int scoreToReach;
   
    
 

    public int player1score = 0;
    public int player2score = 0;

   
    public Text player1ScoreText;
    public Text player2ScoreText;

    public void Player1Goal()
    {
        player1score++;
        player1ScoreText.text = player1score.ToString();
        //to string is used to convert the player 1 score integer to a string

        CheckScore();
    }

    public void Player2Goal()
    {
        player2score++;
        player2ScoreText.text = player2score.ToString();

        CheckScore();
    }

    public void CheckScore()
    {
        if(player1score == scoreToReach)
        {
            SceneManager.LoadScene(2);

        }

        else if(player2score == scoreToReach)
        {
            SceneManager.LoadScene(3);

        }


    }
}
