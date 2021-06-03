using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int _payerScore;
    public Paddle playerPaddle;
    public Paddle computerPaddle;

    public Ball ball;
    public Text computerScoretext;
    public Text pleayerScoretext;


    public int _computerScore;


    public void PlayerScores()
    {
        _payerScore++;
      
        Debug.Log(_payerScore);
        this.pleayerScoretext.text = _payerScore.ToString();
        ResetRound();


    }

    public void Computerscores()
    {
        _computerScore++;
        //this.ball.RestPosition();
        this.computerScoretext.text = _computerScore.ToString();
        Debug.Log(_computerScore);

        ResetRound();

    }
    private void ResetRound()
    {
        this.ball.RestPosition();
        this.computerPaddle.ResetPositiona();
        this.playerPaddle.ResetPositiona();
        this.ball.AddStartingForce();
    }
}
