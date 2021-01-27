using System.Collections.Generic;

namespace Library
{
    public class Database
    {
        //Lag database
        private List<CompanyObject> companiesList = new List<CompanyObject>();
        //Tall some brukes for å gi hver ny bedrift en unik ID
        private int unused_id = 1;

        //Lag et bedrift-objekt basert på verdiene som blir gitt
        private CompanyObject createCompany(int company_vat_nummer, string company_name, string company_created_at) 
        {
            CompanyObject company;

            company = new CompanyObject
            {
                id = unused_id,
                vat_nummer = company_vat_nummer,
                name = company_name,
                created_at = company_created_at
            };

            return company;
        }

        //Lag et bedrift-objekt basert på de gitte verdiene og legg det til i databasen med en unik ID
        public void addCompanyToDB(int company_vat_nummer, string company_name, string company_created_at) 
        {
            //Sjekk om selskapet eksisterer i databasen basert på vat nummeret. 
            bool vat_already_exists = false;
            foreach (CompanyObject company in companiesList)
            {
                if (company.vat_nummer == company_vat_nummer)
                {
                    vat_already_exists = true;
                }
            }
            //Hvis det eksisterer, legg det til i databasen. Hvis ikke, si ifra.
            if (!vat_already_exists)
            {
                CompanyObject company = createCompany(company_vat_nummer, company_name, company_created_at);
                companiesList.Add(company);
                unused_id++;
            }
            else if (vat_already_exists)
            {
                System.Console.WriteLine("Selskapet eksisterer allerede i databasen");
            }
        }

        //Se over database-listen og skriv ned verdiene til alle registrerte bedrifter
        public void listAllCompanies() 
        {
            foreach (CompanyObject company in companiesList)
            {
                System.Console.WriteLine($"{ company.id } / { company.vat_nummer } / { company.name } / { company.created_at }");
            }
        }

        //Søk databasen etter en bedrift med en spesifisert ID
        public void findCompanyByID(int company_id) 
        {
            CompanyObject result = createCompany(0, "", "");

            foreach (CompanyObject company in companiesList)
            {
                if (company.id == company_id) 
                {
                    result = company;
                }
            }
            System.Console.WriteLine($"{ result.id } / { result.vat_nummer } / { result.name } / { result.created_at }");
            //return result;
        }

        //Fjern et selskap fra listen. 
        public void deleteCompany(int company_id)
        {
            int i = 0;
            int foundIndex = -1;
            foreach (CompanyObject company in companiesList)
            {
                if (company.id == company_id)
                {
                    foundIndex = i;
                }
                i++;
            }
            if (foundIndex != -1) 
            {
                companiesList.RemoveAt(foundIndex);
            }
        }

        //Søk gjennom databasen etter en ID, og sett inn ny organisasjonsnummer
        public void updateOrgNumber(int company_id, int company_vat_nummer)
        {
            foreach (CompanyObject company in companiesList)
            {
                if (company.id == company_id)
                {
                    company.vat_nummer = company_vat_nummer;
                }
            }
        }

        //Fyll databasen med et par selskap, for testing. 
        public void fillDatabase()
        {
            addCompanyToDB(12345,"Company1","01.01.2001");
            addCompanyToDB(67890,"Company2","02.02.2002");
            addCompanyToDB(13579,"Company3","03.03.2003");
            addCompanyToDB(24680,"Company4","04.04.2004");
            addCompanyToDB(25240,"Company5","05.05.2005");
            addCompanyToDB(880911392,"Rørkjøp AS","10.06.1999");
        }

    }
}