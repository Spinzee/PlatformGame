using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public int score;
    public int lifeScore;

    public bool playerDiedGameRestarted;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
