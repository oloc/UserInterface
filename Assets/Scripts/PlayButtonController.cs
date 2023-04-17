using UnityEngine;

public class PlayButtonController : MonoBehaviour
{

    [SerializeField]
    private CanvasGroup _canvasGroupToActivate;

    private bool _isActivated;

    public void onClick()
    {
        if (_isActivated)
        {
            _canvasGroupToActivate.alpha = 0;
            _isActivated = false;
        }
        else
        {
            _canvasGroupToActivate.alpha = 1;
            _isActivated = true;
        }
    }
}
