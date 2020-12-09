using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    //[SerializeField] private MainMenu _mainMenu;

    //[SerializeField] private Camera _dummyCamera;

    //public Events.EventFadeComplete OnMainMenuFadeComplete;

    //private void Start()
    //{
    //    DontDestroyOnLoad(gameObject);

    //    _mainMenu.OnFadeComplete.AddListener(HandleMainMenuFadeComplete);

    //    //GameManager.Instance.OnGameStateChanged.AddListener(HandleGameStateChanged);
    //}

    //public void HandleNewGameOnClick()
    //{
    //    if (GameManager.Instance.CurrentGameState == GameManager.GameState.PREGAME)
    //    {
    //        GameManager.Instance.StartGame();
    //    }
    //}

    //private void HandleMainMenuFadeComplete(bool fadeIn)
    //{
    //    // pass it on
    //    OnMainMenuFadeComplete.Invoke(fadeIn);
    //}


    //public void SetDummyCameraActive(bool active)
    //{
    //    _dummyCamera.gameObject.SetActive(active);
    //}
}
