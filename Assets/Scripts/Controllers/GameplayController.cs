﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayController : Singleton<GameplayController>
{
    private TMP_Text scoreText;
    private TMP_Text lifeText;

    private int score;
    private int lifeScore;
    private GameObject gameFinishedText;

    protected override void Awake()
    {
        base.Awake();

        scoreText = GameObject.Find("ScoreText").GetComponent<TMP_Text>();
        lifeText = GameObject.Find("LifeText").GetComponent<TMP_Text>();
        gameFinishedText = GameObject.Find("LevelFinished");
        gameFinishedText.SetActive(false);
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += LevelFinishedLoading;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= LevelFinishedLoading;
    }

    void LevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Gameplay")
        {
            if (!GameManager.Instance.playerDiedGameRestarted)
            {
                score = 0;
                lifeScore = 2;
            }
            else
            {
                score = GameManager.Instance.score;
                lifeScore = GameManager.Instance.lifeScore;
            }
            scoreText.text = "x" + score;
            lifeText.text = "x" + lifeScore;
        }
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = "x" + score;
    }

    public void DecrementLife()
    {
        lifeScore--;
        if (lifeScore >= 0)
        {
            lifeText.text = "x" + lifeScore;
        }
        StartCoroutine(PlayerDied());
    }

    public void PlayerFinished()
    {
        gameFinishedText.SetActive(true);
    }

    IEnumerator PlayerDied()
    {
        yield return new WaitForSeconds(2f);

        if (lifeScore < 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
        else
        {
            GameManager.Instance.playerDiedGameRestarted = true;
            GameManager.Instance.score = score;
            GameManager.Instance.lifeScore = lifeScore;
            SceneManager.LoadScene("Gameplay");
        }
    }
}
