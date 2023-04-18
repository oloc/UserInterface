using UnityEngine;
using UnityEngine.Audio;

public class SettingsInit : MonoBehaviour
{
    [SerializeField]
    private AudioMixer _audioMixer;

    // Start is called before the first frame update
    void Start()
    {
        SetVolume(GameSettingsController.PLAYERPREFS_MAINVOLUME, GameSettingsController.MAINVOLUME_PARAM);
        SetVolume(GameSettingsController.PLAYERPREFS_MUSICVOLUME, GameSettingsController.MUSICVOLUME_PARAM);
        SetVolume(GameSettingsController.PLAYERPREFS_SFXVOLUME, GameSettingsController.SFXVOLUME_PARAM);

        SetVideoQuality(VideoSettingsController.PLAYERPREFS_QUALITYLEVEL);
    }

    private void SetVideoQuality(string prefKey)
    {
        if (PlayerPrefs.HasKey(prefKey))
        {
            int qualityLevel = PlayerPrefs.GetInt(prefKey);
            QualitySettings.SetQualityLevel(qualityLevel);
        }
    }

    private void SetVolume(string prefKey, string volumeParam)
    {
        if (PlayerPrefs.HasKey(prefKey))
        {
            float playerPrefsVolume = PlayerPrefs.GetFloat(prefKey);
            _audioMixer.SetFloat(volumeParam, Mathf.Log10(playerPrefsVolume) * 20);
        }
    }
}
