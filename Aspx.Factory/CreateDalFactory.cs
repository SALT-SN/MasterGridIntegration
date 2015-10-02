using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Aspx.IDAL;

namespace Aspx.Factory
{
    public class CreateDalFactory : IDataAccess
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static ILM CreateLM()
        {
            string className = path + ".LMDAL";
            return (ILM)Assembly.Load(path).CreateInstance(className);
        }

        public static ILMRec CreateLMRec()
        {
            string className = path + ".LMRecDAL";
            return (ILMRec)Assembly.Load(path).CreateInstance(className);
        }

        public static IOption CreateOption()
        {
            string className = path + ".OptionDAL";
            return (IOption)Assembly.Load(path).CreateInstance(className);
        }

        public static IQuestion CreateQuestion()
        {
            string className = path + ".QuestionDAL";
            return (IQuestion)Assembly.Load(path).CreateInstance(className);
        }
          /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IExample CreateExample()
        {
            string className = path + ".ExampleDAL";
            return (IExample)Assembly.Load(path).CreateInstance(className);
        }
        
            /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static ITestResult CreateTestResult()
        {
            string className = path + ".TestResultDAL";
            return (ITestResult)Assembly.Load(path).CreateInstance(className);
        }
        
    }
}
