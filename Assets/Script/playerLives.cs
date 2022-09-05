using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class playerLives : MonoBehaviour
{
    private int lives = 3;
    private int score = 0;
    public TMP_Text Text;
    public TMP_Text scoreText;
    public GameObject loseFilter;

    private void Update()
    {
        Text.text = "Lives: " + lives;

        scoreText.text = "Score: " + score;

        if (Input.GetKey(KeyCode.F))
        {
            ReloadScene();
        }
    }

    public void UpdateScore()
    {
        score += 100;
        scoreText.text = "Score: " + score;
    }

   public void UpdateLives()
    {
        lives -= 1;
        Text.text = "Lives: " + lives;
        if (lives == 0)
        {
            loseFilter.gameObject.SetActive(true);
            
            Time.timeScale = 0;
        }
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
