using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPatternRealTimeExample
{
    // David is from France and can speak and understand only French
    public class David : IFrenchSpeaker
    {
        public string AskQuestion(string Words)
        {
            Console.WriteLine("Question Asked by David [French Speaker and Can understand only French] : " + Words);
            ITarget target = new Pam();
            string replyFromJohn = target.TranslateAndTellToOtherPerson(Words, "English");
            return replyFromJohn;
        }

        public string AnswerFortheQuestion(string Words)
        {
            string reply = null;
            if (Words.Equals("comment allez-vous?", StringComparison.InvariantCultureIgnoreCase))
            {
                reply = "Je suis très bien";
            }
            return reply;
        }
    }
}
