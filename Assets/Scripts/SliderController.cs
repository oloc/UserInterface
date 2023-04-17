using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _textMesh;

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _textMesh.text = _slider.value.ToString("F2");
    }

    public void onSliderValueChanged(float value)
    {
        _textMesh.text = value.ToString("F2");
    }
}
