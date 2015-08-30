using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspx.Model
{
    public class QuestionView
    {
        private int _qid;
        public int qid
        {
            get { return _qid; }
            set { _qid = value; }
        }

        private int _lmid;
        public int lmid
        {
            get { return _lmid; }
            set { _lmid = value; }
        }

        private string _question_des;
        public string question_des
        {
            get { return _question_des; }
            set { _question_des = value; }
        }

        private string _answer_choice;
        public string answer_choice
        {
            get { return _answer_choice; }
            set { _answer_choice = value; }
        }

        private string _composition;
        public string composition
        {
            get { return _composition; }
            set { _composition = value; }
        }
        /// <summary>
        /// get Option
        /// </summary>
        public List<ModOption> OptionList { get; set; }
    }
}
