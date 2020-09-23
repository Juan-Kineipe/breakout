using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int maxScore;
    public Text scoreText;
    public GameObject victory;
    public GameObject gameOver;
    public static GameManager instance;

    private GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        ball = GameObject.FindGameObjectWithTag("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();

        if(score == maxScore) {
            ShowVictory();
        }
    }

    public void ShowVictory()
    {
        victory.SetActive(true);
        Destroy(ball);
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
