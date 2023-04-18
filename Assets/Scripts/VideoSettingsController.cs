using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VideoSettingsController : SettingsController
{
    [SerializeField]
    private TMP_Dropdown _qualityDropdown;
    [SerializeField]
    private Toggle _fullScreen;
    [SerializeField]
    private Toggle _vSync;

    public const string PLAYERPREFS_QUALITYLEVEL = "Graphics:QualityLevel";
    public const string PLAYERPREFS_FULLSCREEN = "Graphics:FullScreen";
    public const string PLAYERPREFS_VSYNC = "Graphics:Vsync";

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey(PLAYERPREFS_QUALITYLEVEL))
        {
            _qualityDropdown.value = PlayerPrefs.GetInt(PLAYERPREFS_QUALITYLEVEL);
        }

        SetToggleFromPrefs(_fullScreen, PLAYERPREFS_FULLSCREEN);
        SetToggleFromPrefs(_vSync, PLAYERPREFS_VSYNC);
    }

    public void UpdateQualityLevel(int qualityLevel)
    {
        QualitySettings.SetQualityLevel(qualityLevel);
        PlayerPrefs.SetInt(PLAYERPREFS_QUALITYLEVEL, qualityLevel);
    }

    public void UpdateFullScreen(bool toggle)
    {
        SaveToggleInPrefs(PLAYERPREFS_FULLSCREEN, toggle);
    }

    public void UpdateVsync(bool toggle)
    {
        SaveToggleInPrefs(PLAYERPREFS_VSYNC, toggle);
    }
}
