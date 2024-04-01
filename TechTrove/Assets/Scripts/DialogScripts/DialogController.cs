using System.Collections.Generic;
using Cinemachine;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DialogScripts
{
    public class DialogController : MonoBehaviour
    {
        [SerializeField] private CinemachineVirtualCamera _camera;
        [SerializeField] private QuestionTemplate _questionTemplate;
        [SerializeField] private AnswerTemplate _answerTemplate;
        [SerializeField] private Transform _container;
        [SerializeField] private Dialog _dialog;

        private Button _continue;
        private List<Button> _listButton;
        private List<TMP_Text> _buttonText;

        private void OnEnable()
        {
            foreach (Transform child in _container)
            {
                Destroy(child.gameObject);
            }
            Render(_dialog);
        }

        public void Render(Dialog dialog)
        {
            Debug.Log(dialog.CorrectAnswer);
            if (dialog.CorrectAnswer<1)
            {
                var dialogPanel = Instantiate(_questionTemplate, _container);
                dialogPanel.Render(dialog);
            }

            if (dialog.CorrectAnswer>0)
            {
                var dialogPanel = Instantiate(_answerTemplate, _container);
                dialogPanel.Render(dialog);
            }
        }
    }
}