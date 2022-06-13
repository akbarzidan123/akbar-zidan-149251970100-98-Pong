using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour
{
    public int leftScore;
    public int rightScore;
    public int maxScore;
    public BallController ball;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Created by Akbar Zidan Al Zakki 149251970100-98");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddRightScore(int increment)
    {
        ball.ResetBall();
        rightScore += increment;
        if(rightScore >= maxScore)
        {
            GameOver();
        }
    }
    public void AddLeftScore(int increment)
    {
        ball.ResetBall();
        leftScore += increment;
        if(leftScore >= maxScore)
        {
            GameOver();
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
