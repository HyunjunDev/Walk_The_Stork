using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    public Text scoreText;
    public Text explainText;
    public Text finalScoreText;
    public GameObject gameOverButton;

    private void Start()
    {
        EventManager.StartEvent += ScoreTrue;
        EventManager.DieEvent += ScoreFalse;
    }

    private void ScoreTrue()
    {
        scoreText.gameObject.SetActive(true);
    }

    private void ScoreFalse()
    {
        scoreText.gameObject.SetActive(false);
        gameOverButton.SetActive(true);
    }

    public void ExplainFalse()
    {
        explainText.gameObject.SetActive(false);
    }

    public void GameOverFalse()
    {
        gameOverButton.SetActive(false);
    }

    public void UpdateScoreText()
    {
        scoreText.text = (int)GameManager.Instance.score + "m";
        finalScoreText.text = scoreText.text;
    }
}
