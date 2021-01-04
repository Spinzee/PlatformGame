using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public int score;
    public int lifeScore;

    public bool playerDiedGameRestarted;

    public AudioSource audio;
    public AudioClip StartGameClip;
    public AudioClip EndGameClip;
    public AudioClip GameMusic;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
    }

    public void PlayAudio(AudioClip clip)
    {
        audio.PlayOneShot(clip);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
