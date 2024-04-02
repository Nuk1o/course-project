using TMPro;
using UnityEngine;

public class DigitalPanel : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    public void WriteTextButton(string text)
    {
        _text.text = _text.text + text;
    }
}
