using DialogScripts;
using UnityEngine;
using Zenject;

public class TriggerPosition : MonoBehaviour
{
    [SerializeField] private GameObject _panelPress;
    [SerializeField] private Dialog _dialog;
    [SerializeField] private GameObject _panelCanvas;
    [Inject] private DialogController _dialogController;
    private GameObject _dialogPanel;
    private bool _isStay = false;
    private bool _isPress = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            _panelPress.SetActive(true);
            _isStay = true;
        }
        Debug.Log(other.gameObject.name);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            _panelPress.SetActive(false);
            _isStay = false;
        }
    }

    private void Update()
    {
        if (_isStay&&Input.GetKey(KeyCode.F)&&!_isPress)
        {
            Debug.Log("Нажал А");
            _isPress = true;
            OpenInfoMenu();
        }
    }

    private void OpenInfoMenu()
    {
        _isPress = false;
        if (_panelCanvas != null)
        {
            _panelCanvas.SetActive(true);
        }
        else if(_dialogPanel == null)
        {
            _dialogPanel = _dialogController.Render(_dialog);
        }
        else
        {
            _dialogPanel.SetActive(true);
        }
    }
}
