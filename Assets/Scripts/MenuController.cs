using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    private string _settingsScene;
    [SerializeField]
    private CanvasGroup _canvasGroupToActivate;

    private void Awake()
    {
        _canvasGroupToActivate.interactable = false;
    }

    public void PlayButtonPressed()
    {
        _canvasGroupToActivate.interactable = !_canvasGroupToActivate.interactable;
        _canvasGroupToActivate.alpha = _canvasGroupToActivate.interactable ? 1f : 0f;
    }

    public void SettingsButtonPressed()
    {
        SceneManager.LoadScene(_settingsScene);
    }

    public void QuitButtonPressed()
    {
        Application.Quit();
    }
}
