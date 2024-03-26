using System;
using UnityEngine;
using Zenject;

public class TriggerPosition : MonoBehaviour
{
    [SerializeField] private GameObject _panelPess;
    [SerializeField] private string _text;
    [Inject] private InfoPanel _infoPanel;

    private bool _isStay = false;
    private GameObject _infoGameObject;

    private void Start()
    {
        _infoGameObject = _infoPanel.button.transform.parent.gameObject;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            _panelPess.SetActive(true);
            _isStay = true;
        }
        Debug.Log(other.gameObject.name);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            _panelPess.SetActive(false);
            _isStay = false;
        }
    }

    private void Update()
    {
        if (_isStay&&Input.GetKey(KeyCode.F))
        {
            Debug.Log("Нажал А");
            OpenInfoMenu();
        }
    }

    private void OpenInfoMenu()
    {
        
        _infoGameObject.SetActive(true);
        _infoPanel.text.text = _text;
        _infoPanel.button.onClick.AddListener(delegate { CloseInfoMenu(); });
    }

    private void CloseInfoMenu()
    {
        _infoGameObject.SetActive(false);
    }
}
