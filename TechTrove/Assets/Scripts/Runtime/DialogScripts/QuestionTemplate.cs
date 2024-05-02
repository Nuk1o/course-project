using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DialogScripts
{
    public class QuestionTemplate : MonoBehaviour
    {
        [SerializeField] private TextTyperTMP _text;
        [SerializeField] private Button _continue;

        public void Render(IDialog dialog)
        {
            _text.textToType = dialog.Questions;
            Debug.Log(dialog.Questions);
            _text.StartTyping();
            _continue.transform.GetComponentInChildren<TMP_Text>().text = dialog.ContinueText;
            _continue.onClick.AddListener(delegate { ClickContinue(); });
        }

        private void ClickContinue()
        {
            gameObject.SetActive(false);
        }
    }
}