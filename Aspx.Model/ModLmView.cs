using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspx.Model
{
    public class ModLmView
    {
        /// <summary>
        /// Demo
        /// </summary>
        public ModLM lm { get; set; }
        public ModLMRec lmrec { get; set; }
        /// <summary>
        /// Demo
        /// </summary>
        public ModExample Example { get; set; }
        public String Like { get; set; }
        /// <summary>
        /// QuestionList
        /// </summary>
        public List<QuestionView> QuestionList { get; set; }
    }
}
