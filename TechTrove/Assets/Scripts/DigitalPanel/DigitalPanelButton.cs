using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class DigitalPanelButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private TMP_Text _textButton;
    [Inject]private DigitalPanel _digitalPanel;

    private void OnEnable()
    {
        _button.onClick.AddListener(delegate { WriteTextButton(); });
    }

    private void OnDisable()
    {
        _button.onClick.RemoveAllListeners();
    }

    private void WriteTextButton()
    {
        _digitalPanel.WriteTextButton(_textButton.text);
    }
}