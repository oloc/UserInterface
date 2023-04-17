using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsButtonController : MonoBehaviour
{

    [SerializeField]
    private string _settingsScene;

    public void ButtonPressed()
    {
        SceneManager.LoadScene(_settingsScene);
    }
}
