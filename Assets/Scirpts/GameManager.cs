using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverObject, lifeText, scoreText;
    public Text Score ;
    void Start()
    {
        Score = GetComponent<Text>();
    }
    public void GameOver()
    {
        Score.text ="GAME OVER\n" + "Score: " + score.scoreValue.ToString();
        GameOverObject.SetActive(true);
        lifeText.SetActive(false);
        scoreText.SetActive(false);
        Life.lifeValue = 0;
        score.scoreValue = 0;
        Time.timeScale = 0;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
