using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    private Sprite _defaultSprite;
    [SerializeField]
    private Sprite _highlightedSprite;
    [SerializeField]
    private Sprite _pressedSprite;

    private Button _button;

    public void OnPointerEnter(PointerEventData eventData)
    {
        _button.image.sprite = _highlightedSprite;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _button.image.sprite = _defaultSprite;
    }

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

}
