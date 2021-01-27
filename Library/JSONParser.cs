namespace Library
{
    public class JSONParser
    {
        //Svært simpel og antageligvis gal JSON parser. Jeg har ikke lært hvordan gjøre dette på en bedre metode. 

        public string parseCommand(string json)
        {
            string command = "";

            if (json.Substring(0,7).Contains("GET")) 
            {
                command = "get";
            }
            else if (json.Substring(0,7).Contains("POST"))
            {
                command = "post";
            }
            else if (json.Substring(0,7).Contains("PATCH"))
            {
                command = "patch";
            }
            else if (json.Substring(0,7).Contains("DELETE"))
            {
                command = "delete";
            }

            return command;
        }

        public string parseAttributes(string json)
        {
            return "";
        }
    }
}