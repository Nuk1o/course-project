using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DialogScripts
{
    public class QuestionTemplate : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
        [SerializeField] private Button _continue;

        public void Render(IDialog dialog)
        {
            _text.text = dialog.Questions;
            _continue.transform.GetComponentInChildren<TMP_Text>().text = dialog.ContinueText;
            _continue.onClick.AddListener(delegate { ClickContinue(); });
        }

        private void ClickContinue()
        {
            gameObject.SetActive(false);
        }
    }
}