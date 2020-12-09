using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        GameManager.Instance.playerDiedGameRestarted = false;
        SceneManager.LoadScene("Gameplay");
    }
}
