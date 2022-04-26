using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scoreMulti;

    public const string HighScore = "HighScore";

    private float score;
   
    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime*scoreMulti;
        scoreText.text = Mathf.FloorToInt(score).ToString();
    }

    private void OnDestroy()
    {
        int currentHighScore=PlayerPrefs.GetInt(HighScore, 0);

        if (score > currentHighScore)
        {
            PlayerPrefs.SetInt(HighScore, Mathf.FloorToInt(score));
        }


    }
}
