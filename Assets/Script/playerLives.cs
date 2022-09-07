using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class playerLives : MonoBehaviour
{
    private int lives = 3;
    public TMP_Text Text;
    public GameObject loseFilter;
    public GameObject duringPlay;

    private int score = 0;
    private int highScore = 0;
    public TMP_Text scoreText;
    public TMP_Text loseScoreText;
    public TMP_Text highScoreText;
   
    public AudioSource source;
    public AudioClip loseLife;

    private void Start()
    {
        scoreText.text = "Score: " + score;
        Text.text = "Lives: " + lives;
        loseScoreText.text = scoreText.text;
    }
    private void Update()
    {


        if (Input.GetKey(KeyCode.F))
        {
            ReloadScene();
        }
    }
    public void UpdateScore()
    {
        score += 1;
        scoreText.text = "Score: " + score;
        loseScoreText.text = scoreText.text;
        if(score > highScore)
        {
            highScoreText.text = scoreText.text;
        }
    }

    public void UpdateLives()
    {
        lives -= 1;
        source.PlayOneShot(loseLife);
        Text.text = "Lives: " + lives;
        if (lives == 0)
        {
            loseFilter.gameObject.SetActive(true);
            duringPlay.gameObject.SetActive(false);

            
            Time.timeScale = 0;
        }
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
