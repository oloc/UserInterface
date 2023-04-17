using UnityEngine;

public class PlayButtonController : MonoBehaviour
{

    [SerializeField]
    private CanvasGroup _canvasGroupToActivate;

    private void Awake()
    {
        _canvasGroupToActivate.interactable = false;
    }

    public void onClick()
    {
        _canvasGroupToActivate.interactable = !_canvasGroupToActivate.interactable;
        _canvasGroupToActivate.alpha = _canvasGroupToActivate.interactable ? 1f : 0f;
    }
}
