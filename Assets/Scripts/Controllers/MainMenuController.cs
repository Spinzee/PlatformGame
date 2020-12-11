using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        GameManager.Instance.playerDiedGameRestarted = false;

        Invoke("DelayStart", 2);
    }

    // TODO Get rid of these delays and set up observer pattern
    public void DelayStart()
    {
        GameManager.Instance.PlayAudio(GameManager.Instance.GameMusic);
        SceneManager.LoadScene("Gameplay");
    }
}
