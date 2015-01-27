using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

using System.Net;
using System.Web;
using Newtonsoft.Json;
using MoreLinq;

namespace Quiz_Question_Answerer
{
    class Question
    {
        private string api_key = "change_me";
        private string api_endpoint = "https://api.datamarket.azure.com/Bing/Search/v1/Web?Query=";

        private List<Answer> answers = new List<Answer>();
        private string question_text;

        public Question(string q)
        {
            this.question_text = q;
        }

        public void addAnswer(string answer)
        {
            answers.Add(new Answer(answer));
        }


        public string guessAnswer()
        {              
            //Build Webclient
            WebClient client = new WebClient();
            client.Headers.Add("Authorization", "Basic " + encodeAPIkey());
            client.Headers.Add("Content-Type", "application/json");

            //Get JSON Response
            try
            {
                string response = client.DownloadString(api_endpoint + HttpUtility.UrlEncode("'" + this.question_text + "'") + "&$Format=JSON");
                BingResponse.Rootobject bingResults = JsonConvert.DeserializeObject<BingResponse.Rootobject>(response);

                foreach (BingResponse.Result result in bingResults.d.results)
                {
                    foreach (string descriptionWord in stripSearchWords(result.Description).Split(' '))
                    {
                        foreach (var answer in answers)
                        {
                            foreach(string answerWord in answer.Answer_Text.Split(' ')) {
                                if (descriptionWord.ToLower() == answerWord.ToLower())
                                {
                                    answer.IncrementCount();
                                }
                            }
                        }
                    }
                }

                return answers.MaxBy(i => i.Count).Answer_Text;
            }
            catch(WebException)
            {
                return "API error";
            }
            catch(Exception ex)
            {              
                return ex.Message;
            }
        }

        private string encodeAPIkey()
        {
            byte[] accountKeyBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(this.api_key + ":" + this.api_key);
            return Convert.ToBase64String(accountKeyBytes).Trim();
        }

        private string stripSearchWords(string txt)
        {
            foreach (var word in this.question_text.Split(' '))
            {
                if (txt.ToLower().Contains(word.ToLower()))
                {
                    txt = txt.Replace(word, "");
                }
            }

            return txt;
        }
    }
}
