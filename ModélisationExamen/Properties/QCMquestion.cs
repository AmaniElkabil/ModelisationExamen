using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class QCMquestion : Question
    {
        protected string question;
        protected int id;
        protected string choix; 

        public QCMquestion(string question , int id , string choix) 
        {
            this.question = question;
            this.id = id;
            this.choix = choix; 
        }
        public Addchix (bool valeur)
        {
        }
    }
}
