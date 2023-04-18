using TMPro;
using UnityEngine;

public class VideoSettingsController : MonoBehaviour
{
    [SerializeField]
    private TMP_Dropdown _qualityDropdown;

    public const string PLAYERPREFS_QUALITYLEVEL = "Graphics:QualityLevel";

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey(PLAYERPREFS_QUALITYLEVEL))
        {
            _qualityDropdown.value = PlayerPrefs.GetInt(PLAYERPREFS_QUALITYLEVEL);
        }
    }

    public void UpdateQualityLevel(int qualityLevel)
    {
        QualitySettings.SetQualityLevel(qualityLevel);
        PlayerPrefs.SetInt(PLAYERPREFS_QUALITYLEVEL, qualityLevel);
    }
}
