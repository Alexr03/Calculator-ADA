using System;
using System.Collections.Generic;

namespace FirstAdaTask.Utilities
{
    public static class InputUtilities
    {
        public static string GetResponse(string question)
        {
            string response = string.Empty;
            while (string.IsNullOrEmpty(response))
            {
                Console.WriteLine(question);
                response = Console.ReadLine();
            }

            return response;
        }
        
        public static object[] GetResponseArray(string question)
        {
            string response = string.Empty;
            List<object> arrayResponse = new List<object>();
            
            while (string.IsNullOrEmpty(response))
            {
                Console.WriteLine(question);
                response = Console.ReadLine();
                if (string.IsNullOrEmpty(response))
                {
                    continue;
                }
                
                arrayResponse.AddRange(response.Split(','));
            }

            return arrayResponse.ToArray();
        }
    }
}