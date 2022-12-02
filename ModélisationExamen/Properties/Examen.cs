using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModélisationExamen
{
    internal class Examen
    {
        private int id;
        public int durre { get; set; }
        public DateTime date { get; set }
      

        public List<Question> questions { get; }

        public Exam(int id, String level, DateTime date, int durre, List<Question> questions)
        {
            this.id = id;
            this.durre = durre;
            this.questions = questions;
        }
    }
}