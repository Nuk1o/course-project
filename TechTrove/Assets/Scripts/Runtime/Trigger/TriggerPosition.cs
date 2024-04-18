using DialogScripts;
using UnityEngine;
using Zenject;

public class TriggerPosition : MonoBehaviour
{
    [SerializeField] private GameObject _panelPress;
    [SerializeField] private Dialog _dialog;
    [Inject] private DialogController _dialogController;
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
            OpenInfoMenu();
            _isPress = true;
        }
    }

    private void OpenInfoMenu()
    {
        _dialogController.Render(_dialog);
    }
}
