namespace Library
{
    public class JSONParser
    {
        //Parsing av JSON objekter foregår her. Ettersom jeg er usikker på hvordan dette gjøres, er ideen at JSON blir konverter til en string, og behandles herifra. 

        //parseCommand brukes for å hente kommandoer fra toppen av JSON objektet. 
        public string parseCommand(string json)
        {
            string command = "";

            if (json.Substring(0,5).Contains("GET")) 
            {
                command = "get";
            }
            else if (json.Substring(0,5).Contains("POST"))
            {
                command = "post";
            }
            else if (json.Substring(0,5).Contains("PATCH"))
            {
                command = "patch";
            }
            else if (json.Substring(0,5).Contains("DELETE"))
            {
                command = "delete";
            }

            return command;
        }

        public CompanyObject parseAttributes(string json)
        {
            //Å hente individuelle attributter fra en json i C# er noe jeg ikke vet hvordan jeg skal gjøre, og jeg har ikke nok tid til å finne ut av det.

            //Antar at en JSON har blitt parset og attributtene under har blitt hentet ut.
            int json_id = 1;
            int json_vat_nummer = 880911392;
            string json_name = "Rørkjøp AS";
            string json_created_at = "10.06.1999";

            CompanyObject jsonAttributes = new CompanyObject
            {
                id = json_id,
                vat_nummer = json_vat_nummer,
                name = json_name,
                created_at = json_created_at
            };

            return jsonAttributes;
        }
    }
}