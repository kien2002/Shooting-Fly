using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DeathZone : MonoBehaviour
{
    [SerializeField]
    GameObject panel;
    public static DeathZone instance;
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
        highscore = PlayerPrefs.GetInt("", 0);
        panel.SetActive(false);
        scorceText.text = score.ToString();
        highscoreText.text = highscore.ToString();
    }

    // Update is called once per frame
    public void AddPoint()
    {
        score += 1;
        scorceText.text = score.ToString();
        if(highscore<score)
        PlayerPrefs.SetInt("",score);
    }
    void OpenPanel()
    {
        panel.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
        else
        {
            OpenPanel();
        }
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
