using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModélisationExamen
{
    internal class Normalquestion : Question
    {
        protected string question;
        protected int id;
        protected char reponse; 

        public QCMquestion(string question , int id , char reponse) 
        {
            this.question = question;
            this.id = id;
            this.reponse = reponse; 
        }
        public reponse ()
        {
        }
    }
}
