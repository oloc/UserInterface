using UnityEngine;

public class ToggleController : MonoBehaviour
{
    private bool _isOn;

    public void onValueChanged(bool value)
    {
        _isOn = value;
    }
}
