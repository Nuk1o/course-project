using System.Collections.Generic;
using UnityEngine;

namespace DialogScripts
{
    [CreateAssetMenu (menuName = "Dialog")]
    public class Dialog : ScriptableObject, IDialog
    {
        [SerializeField] private string _questions;
        [SerializeField] private List<string> _listAnswer;
        [SerializeField] private int _corrctAnswer;
        [SerializeField] private string _continueText;

        public string Questions => _questions;
        public List<string> ListAnswers => _listAnswer;
        public int CorrectAnswer => _corrctAnswer;
        public string ContinueText => _continueText;

        
    }
}