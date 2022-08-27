using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public float bs = -1;

    public float bi = 4;

    public float score = 0;

    public GameObject stork;

    public bool isGameOver = true;

    private void Start()
    {
        EventManager.StartEvent += GameSetting;
        EventManager.DieEvent += EndGame;
    }

    public void AddScore(float newScore)
    {
        score += newScore;
    }

    public void GameSetting()
    {
        bs = -1;
        bi = 4;
        isGameOver = false;
    }

    public void EndGame()
    {
        isGameOver = true;
    }

    public void StartGame()
    {
        stork.SetActive(true);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit(); 
#endif
    }
}
