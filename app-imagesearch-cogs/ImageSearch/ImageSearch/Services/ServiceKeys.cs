using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageSearch.Services
{
    public class GoogleServicesKeys
    {
        //Setup a custom search with Image enabled with a website of *: https://cse.google.com/cse/
        public const string APIKey = "__ENTER YOUR KEY__";
        public const string CX = "__ENTER YOUR CX__";
    }

    public class CognitiveServicesKeys
    {
        //Setup a Emotion API key for Cognitive Services at: https://www.microsoft.com/cognitive-services/
        public const string Emotion = "93b7df133d7149fdbeb5729b8586d293";

		//Setup a Bing Search API key from: http://www.microsoft.com/cognitive-services
		public const string BingSearch = "8b2d651131aa4e39acd2f3cf850f1e9f";

	} 
}
