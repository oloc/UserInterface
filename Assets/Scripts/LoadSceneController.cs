using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneController : MonoBehaviour
{

    [SerializeField]
    private string _sceneToLoad;

    public void ButtonPressed()
    {
        SceneManager.LoadScene(_sceneToLoad);
    }
}
