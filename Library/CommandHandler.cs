namespace Library
{
    public class CommandHandler
    {
        //Håndtering av GET, POST, PATCH og DELETE kommandoer foregår her. 
        //1: Kalles automatisk når JSON blir sendt til Web API. 
        //2: Informasjon hentes fra (JSONParser).parseCommand(string json) og (JSONParser).parseAttributes(string json).
        //3: Avhengig av resultatet fra parseCommand, blir passende kommandoer for databasen utført. 
        //   - GET uten ID lister opp hele databasen,                   bruker db.listAllCompanies()
        //   - GET med ID lister kun opp bedriften med passende ID,     bruker db.findCompanyByID(int company_id)
        //   - POST med passende info lager ny bedrift i databasen,     bruker db.addCompanyToDB(int company_vat_nummer, string company_name, string company_created_at) 
        //   - PATCH med ID og vat_nummer oppdaterer angitt bedrift,    bruker db.updateOrgNumber(int company_id, int company_vat_nummer)
        //   - DELETE med ID fjerner angitt bedrift fra databasen,      bruker db.deleteCompany(int company_id)
    }
}