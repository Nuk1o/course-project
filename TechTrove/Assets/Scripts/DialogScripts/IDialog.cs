using System.Collections.Generic;

namespace DialogScripts
{
    public interface IDialog
    {
        string Questions { get; }
        List<string> ListAnswers { get; }
        int CorrectAnswer { get; }
        
        string ContinueText { get; }
    }
}