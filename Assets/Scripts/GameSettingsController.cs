using UnityEngine;
using UnityEngine.Audio;

public class GameSettingsController : MonoBehaviour
{
    [SerializeField]
    private AudioMixer _audioMixer;

    private const string MAINVOLUME_PARAM = "MainVolume";
    private const string MUSICVOLUME_PARAM = "MusicVolume";
    private const string SFXVOLUME_PARAM = "SFXVolume";

    public void SetDialogSpeed(float dialogSpeed)
    {
        // Nothing yet
    }

    public void SetMainVolume(float volume)
    {
        _audioMixer.SetFloat(MAINVOLUME_PARAM, Mathf.Log10(volume) * 20);
    }

    public void SetMusicVolume(float volume)
    {
        _audioMixer.SetFloat(MUSICVOLUME_PARAM, Mathf.Log10(volume) * 20);
    }

    public void SetSFXVolume(float volume)
    {
        _audioMixer.SetFloat(SFXVOLUME_PARAM, Mathf.Log10(volume) * 20);
    }

    public void SetToolTips(bool toggle)
    {
        // Nothing yet
    }
}
