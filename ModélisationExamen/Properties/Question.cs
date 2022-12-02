using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModélisationExamen
{
    internal class Question
    {
        int id;
        string question;
        int note; 
    }
    public  (int id, int note , string question) 
    {
        this.id = id;
        this.note = note;
        this.question = question;

    }
}