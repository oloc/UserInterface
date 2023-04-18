using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GameSettingsController : MonoBehaviour
{
    [SerializeField]
    private AudioMixer _audioMixer;
    [SerializeField]
    private Slider _mainVolumeSlider;
    [SerializeField]
    private Slider _musicVolumeSlider;
    [SerializeField]
    private Slider _sfxVolumeSlider;

    // Exposed mixer parameters
    public const string MAINVOLUME_PARAM = "MainVolume";
    public const string MUSICVOLUME_PARAM = "MusicVolume";
    public const string SFXVOLUME_PARAM = "SFXVolume";

    // PlayerPrefs keys
    public const string PLAYERPREFS_MAINVOLUME = "Sound:MainVolume";
    public const string PLAYERPREFS_MUSICVOLUME = "Sound:MusicVolume";
    public const string PLAYERPREFS_SFXVOLUME = "Sound:SFXVolume";


    private void Start()
    {
        SlideVolume(_mainVolumeSlider, PLAYERPREFS_MAINVOLUME);
        SlideVolume(_musicVolumeSlider, PLAYERPREFS_MUSICVOLUME);
        SlideVolume(_sfxVolumeSlider, PLAYERPREFS_SFXVOLUME);
    }

    private void SlideVolume(Slider slider, string key)
    {
        if (PlayerPrefs.HasKey(key))
        {
            float playerPrefsVolume = PlayerPrefs.GetFloat(key);
            slider.value = playerPrefsVolume;
        }
    }

    public void SetDialogSpeed(float dialogSpeed)
    {
        // Nothing yet
    }

    public void SetMainVolume(float volume)
    {
        _audioMixer.SetFloat(MAINVOLUME_PARAM, Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat(PLAYERPREFS_MAINVOLUME, volume);
        PlayerPrefs.Save();
    }

    public void SetMusicVolume(float volume)
    {
        _audioMixer.SetFloat(MUSICVOLUME_PARAM, Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat(PLAYERPREFS_MUSICVOLUME, volume);
        PlayerPrefs.Save();
    }

    public void SetSFXVolume(float volume)
    {
        _audioMixer.SetFloat(SFXVOLUME_PARAM, Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat(PLAYERPREFS_SFXVOLUME, volume);
        PlayerPrefs.Save();
    }

    public void SetToolTips(bool toggle)
    {
        // Nothing yet
    }
}
