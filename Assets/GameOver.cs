using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static GameOver instance;
    public Text scorceText;
    public Text highscoreText;
    int score = 0;
    int highscore = 0;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        scorceText.text = score.ToString();
        highscoreText.text = highscore.ToString();
    }

    public void AddPoint()
    {
        score += 1;
        scorceText.text ="$ :"+ score.ToString();
    }
    public void ReplayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
