using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DigitalPanel : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Button _continue;

    private void OnEnable()
    {
        _text.text = "";
        _continue.onClick.AddListener(delegate { CheckCodeText(); });
    }

    private void OnDisable()
    {
        _continue.onClick.RemoveAllListeners();
    }

    private void CheckCodeText()
    {
        
    }

    public void WriteTextButton(string text)
    {
        _text.text = _text.text + text;
    }
}
