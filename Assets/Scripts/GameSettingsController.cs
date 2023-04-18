using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GameSettingsController : SettingsController
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
        SetSliderFromPrefs(_mainVolumeSlider, PLAYERPREFS_MAINVOLUME);
        SetSliderFromPrefs(_musicVolumeSlider, PLAYERPREFS_MUSICVOLUME);
        SetSliderFromPrefs(_sfxVolumeSlider, PLAYERPREFS_SFXVOLUME);
        SetSliderFromPrefs(_dialogSpeed, PLAYERPREFS_DIALOGSPEED);
        SetToggleFromPrefs(_toolTips, PLAYERPREFS_TOOLTIPS);
    }

    public void SetDialogSpeed(float dialogSpeed)
    {
        SaveFloatInPrefs(PLAYERPREFS_DIALOGSPEED, dialogSpeed);
    }

    public void SetMainVolume(float volume)
    {
        _audioMixer.SetFloat(MAINVOLUME_PARAM, Mathf.Log10(volume) * 20);
        SaveFloatInPrefs(PLAYERPREFS_MAINVOLUME, volume);
    }

    public void SetMusicVolume(float volume)
    {
        _audioMixer.SetFloat(MUSICVOLUME_PARAM, Mathf.Log10(volume) * 20);
        SaveFloatInPrefs(PLAYERPREFS_MUSICVOLUME, volume);
    }

    public void SetSFXVolume(float volume)
    {
        _audioMixer.SetFloat(SFXVOLUME_PARAM, Mathf.Log10(volume) * 20);
        SaveFloatInPrefs(PLAYERPREFS_SFXVOLUME, volume);
    }

    public void SetToolTips(bool toggle)
    {
        SaveToggleInPrefs(PLAYERPREFS_TOOLTIPS, toggle);
    }
}
