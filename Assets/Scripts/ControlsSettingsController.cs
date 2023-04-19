using UnityEngine;
using UnityEngine.UI;

public class ControlsSettingsController : SettingsController
{
    [SerializeField]
    private Toggle _invertMouse;

    private const string PLAYERPREFS_INVERTMOUSE = "Controls:InvertMouse";

    void Start()
    {
        SetToggleFromPrefs(_invertMouse, PLAYERPREFS_INVERTMOUSE);
    }

    public void SetInvertMouse(bool toggle)
    {
        SaveToggleInPrefs(PLAYERPREFS_INVERTMOUSE, toggle);
    }
}
