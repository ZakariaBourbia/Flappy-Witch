using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
    public int score;
    public int highscore;
    public Text scoreText;
    public Text highscoreText;
    public GameObject gameoverscreen;
    public GameObject S1;
    public GameObject S2;
    public GameObject S3;
    public GameObject S4;
    public GameObject M2;
    public GameObject M3;
    public GameObject M4;
    [ContextMenu ( " increase score ")]
    public void addscore()
    {
        score += 1;
        scoreText.text = score.ToString();
        if(score == 3)
            S1.SetActive(true);
        if (score == 9)
            S2.SetActive(true);
        if (score == 15)
            S3.SetActive(true);
        if (score == 21)
            S4.SetActive(true);
        if (score == 6)
            M2.SetActive(true);
        if (score == 12)
            M3.SetActive(true);
        if (score == 18)
            M4.SetActive(true);
    }

    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameoverscreen.SetActive(true);

        
    }
}
