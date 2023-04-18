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
    [SerializeField]
    private Slider _dialogSpeed;
    [SerializeField]
    private Toggle _toolTips;


    // Exposed mixer parameters
    public const string MAINVOLUME_PARAM = "MainVolume";
    public const string MUSICVOLUME_PARAM = "MusicVolume";
    public const string SFXVOLUME_PARAM = "SFXVolume";

    // PlayerPrefs keys
    public const string PLAYERPREFS_MAINVOLUME = "Sound:MainVolume";
    public const string PLAYERPREFS_MUSICVOLUME = "Sound:MusicVolume";
    public const string PLAYERPREFS_SFXVOLUME = "Sound:SFXVolume";

    private const string PLAYERPREFS_DIALOGSPEED = "Dialog:Speed";
    private const string PLAYERPREFS_TOOLTIPS = "ToolTips";


    private void Start()
    {
        SetSlider(_mainVolumeSlider, PLAYERPREFS_MAINVOLUME);
        SetSlider(_musicVolumeSlider, PLAYERPREFS_MUSICVOLUME);
        SetSlider(_sfxVolumeSlider, PLAYERPREFS_SFXVOLUME);
        SetSlider(_dialogSpeed, PLAYERPREFS_DIALOGSPEED);
        SetToogle(_toolTips, PLAYERPREFS_TOOLTIPS);
    }

    private void SetSlider(Slider slider, string key)
    {
        if (PlayerPrefs.HasKey(key))
        {
            float playerPrefsVolume = PlayerPrefs.GetFloat(key);
            slider.value = playerPrefsVolume;
        }
    }

    public void SetDialogSpeed(float dialogSpeed)
    {
        PlayerPrefs.SetFloat(PLAYERPREFS_DIALOGSPEED, dialogSpeed);
        PlayerPrefs.Save();
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

    private void SetToogle(Toggle toogle, string key)
    {
        if (PlayerPrefs.HasKey(key))
        {
            int state = PlayerPrefs.GetInt(key);
            toogle.isOn = state == 1;
        }
    }

    public void SetToolTips(bool toggle)
    {
        PlayerPrefs.SetInt(PLAYERPREFS_TOOLTIPS, toggle ? 1 : 0);
        PlayerPrefs.Save();
    }
}
