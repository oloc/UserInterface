using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{

    public void SaveFloatInPrefs(string key, float value)
    {
        PlayerPrefs.SetFloat(key, value);
        PlayerPrefs.Save();
    }
    public void SaveToggleInPrefs(string key, bool toggle)
    {
        PlayerPrefs.SetInt(key, toggle ? 1 : 0);
        PlayerPrefs.Save();
    }

    public void SetSliderFromPrefs(Slider slider, string key)
    {
        if (PlayerPrefs.HasKey(key))
        {
            float valueSlider = PlayerPrefs.GetFloat(key);
            slider.value = valueSlider;
        }
    }

    public void SetToggleFromPrefs(Toggle toogle, string key)
    {
        if (PlayerPrefs.HasKey(key))
        {
            int state = PlayerPrefs.GetInt(key);
            toogle.isOn = state == 1;
        }
    }

}
