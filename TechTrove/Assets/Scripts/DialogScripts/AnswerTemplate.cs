using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DialogScripts
{
    public class AnswerTemplate : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
        [SerializeField] private Button _buttonTemplate;
        [SerializeField] private Transform _container;
        [SerializeField] private List<Button> _buttons;

        public void Render(IDialog dialog)
        {
            _text.text = dialog.Questions;
            foreach (string textButton in dialog.ListAnswers)
            {
                Button _button = Instantiate(_buttonTemplate, _container);
                _button.transform.GetComponentInChildren<TMP_Text>().text = textButton;
                _buttons.Add(_button);
            }
        }
    }
}