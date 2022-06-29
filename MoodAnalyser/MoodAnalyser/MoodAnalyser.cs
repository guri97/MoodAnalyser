using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssesmentMoodAnalyser
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser()
        {
            this.message = "i am in SAD mood";

        }

        public MoodAnalyser(string message)
        {
            this.message = message.ToUpper();
        }
        public string AnalyseMood()
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                    return "SAD";
                else if (message.Equals(string.Empty))
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MOOD, "Mood should not be empty");
                else return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MOOD, "Mood Should Not Be Null");
                //return "HAPPY";
            }
        }
        public string AnalyseMoodWithoutConstructor(string message)
        {
            if (message.ToLower().Contains("sad"))
                return "SAD";

            else return "HAPPY";

        }
    }
}