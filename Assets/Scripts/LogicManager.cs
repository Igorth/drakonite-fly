using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    [SerializeField] private AudioSource winPointSFX;
    [SerializeField] private AudioSource gameOverSFX;

    //With this ContextMenu you can ran inside the game withou finishing
    //implementation
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();

        winPointSFX.Play();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        Debug.Log(gameOverSFX);
        gameOverSFX.Play();
        gameOverScreen.SetActive(true);
    }
}
