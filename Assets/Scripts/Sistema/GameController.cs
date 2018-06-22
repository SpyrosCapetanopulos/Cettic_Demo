using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameController : MonoBehaviour {

    public Text scoreText;
    public int score;
    public Text namePlayer;

    void Start()
    {
        namePlayer.text = PlayerPrefs.GetString("PlayerName");
        score = 0;
        UpdateScore();
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Puntuación: " + score;
    }
}