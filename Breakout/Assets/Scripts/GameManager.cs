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
    public AudioClip victoryAudio;
    public AudioClip gameOverAudio;
    public GameObject victory;
    public GameObject gameOver;
    public static GameManager instance;

    private AudioSource audio;
    private GameObject player;
    private GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        player = GameObject.FindGameObjectWithTag("Player");
        ball = GameObject.FindGameObjectWithTag("Ball");
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void ShowVictory()
    {
        victory.SetActive(true);
        Destroy(player);
        Destroy(ball);
        audio.PlayOneShot(victoryAudio);
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
        Destroy(player);
        Destroy(ball);
        audio.PlayOneShot(gameOverAudio);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
