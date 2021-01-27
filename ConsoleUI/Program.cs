using System;
using Library;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            UI appUI = new UI();
            Database db = new Database();
            
            //--------------------------------------------

            //Enkel konsoll-basert meny.

            bool quit = false;
            db.fillDatabase();

            while(!quit) 
            {
                appUI.showMenu();
                int menuSelection = Convert.ToInt32(Console.ReadLine());
                switch (menuSelection) 
                {
                    case 1:
                        System.Console.WriteLine("Lister opp alle bedrifter i databasen...");
                        System.Console.WriteLine("-----------------------------------");
                        db.listAllCompanies();
                        appUI.wait();
                        break;
                    case 2:
                        System.Console.WriteLine("Finn bedrift basert på ID:");
                        menuSelection = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("-----------------------------------");
                        db.findCompanyByID(menuSelection);
                        appUI.wait();
                        break;
                    case 3:
                        int vat_nummer;
                        string name;
                        string created_at;
                        System.Console.WriteLine("Skriv in vat nummer");
                        vat_nummer = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Skriv inn bedriftnavn");
                        name = Console.ReadLine();
                        System.Console.WriteLine("Skriv inn startdato");
                        created_at = Console.ReadLine();
                        db.addCompanyToDB(vat_nummer, name, created_at);
                        appUI.wait();
                        break;
                    case 4:
                        System.Console.WriteLine("Sett inn ID på bedriften som skal slettes:");
                        menuSelection = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("-----------------------------------");
                        db.deleteCompany(menuSelection);
                        appUI.wait();
                        break;
                    case 5:
                        System.Console.WriteLine("Skriv inn bedriftens ID");
                        int orgID = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Skriv inn nytt organisasjonsnummer");
                        int orgNr = Convert.ToInt32(Console.ReadLine());
                        db.updateOrgNumber(orgID, orgNr);
                        appUI.wait();
                        break;
                    case 6:
                        quit = true;
                        break;
                    default:
                        System.Console.WriteLine("Ugyldig valg");
                        break;
                }
            }
            System.Console.WriteLine("Applikasjonen avslutter");

            
            //Test add-to-database and check if ID works
            //CompanyObject company = db.createCompany(2523532,"Company6","06.06.2006");
            //company = db.createCompany(4350945,"Company7","07.07.2007");
            //db.addCompanyToDB(company);
            //db.listAllCompanies(db.companiesList);

            //Test delete from database
            //db.deleteCompany(2);
            //db.listAllCompanies();

            //Test find company by ID
            //CompanyObject company = db.findCompanyByID(2);
            //System.Console.WriteLine($"{ company.id } / { company.vat_nummer } / { company.name } / { company.created_at }");

        }

    }
}
