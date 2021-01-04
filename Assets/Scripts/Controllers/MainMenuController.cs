using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] GameObject options;
    [SerializeField] GameObject optionsMenu;
    [SerializeField] GameObject optionsCursor;
    [SerializeField] GameObject pallet;
        
    private float originalVolume;

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

    public void DisplayOptions()
    {
        originalVolume = GetComponent<AudioSource>().volume;
        Invoke("DelayOptions", 2);
    }

    public void DelayOptions()
    {
        options.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void SaveOptions()
    {
        options.SetActive(true);
        optionsMenu.SetActive(false);
        optionsCursor.SetActive(false);
        pallet.SetActive(false);
    }

    public void CancelOptions()
    {
        GetComponent<AudioSource>().volume = originalVolume;
        options.SetActive(true);
        optionsMenu.SetActive(false);
        optionsCursor.SetActive(false);
        pallet.SetActive(false);
    }
}
