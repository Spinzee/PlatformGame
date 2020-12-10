using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        GameManager.Instance.playerDiedGameRestarted = false;
        Invoke("DelayStart", 2);
    }

    public void DelayStart()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
