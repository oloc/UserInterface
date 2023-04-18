using UnityEngine;
using UnityEngine.Audio;

public class GameSettingsController : MonoBehaviour
{
    [SerializeField]
    private AudioMixer _audioMixer;
    private const string MAINVOLUME_PARAM = "MainVolume";

    public void SetMainVolume(float volume)
    {
        _audioMixer.SetFloat(MAINVOLUME_PARAM, Mathf.Log10(volume) * 20);
    }

}
