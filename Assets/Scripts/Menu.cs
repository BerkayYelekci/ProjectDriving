using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Menu : MonoBehaviour
{
    [SerializeField] private TMP_Text highScoreText;

    private void Start()
    {
        int highScore = PlayerPrefs.GetInt(ScoreHandler.HighScore, 0);
        highScoreText.text = $"High Score: {highScore} ";
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
