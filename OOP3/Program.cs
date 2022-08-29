using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //İNTERFACELERDE REFERANS NUMARALARINI TUTAR. O NEDENLE İMPLEMENTASYONU YAPILAN SINIFLARIN YERİNE KULLANILABİLİRLER. 
            //ConsumerCreditManager consumerCreditManager=new ConsumerCreditManager();
            ICreditManager consumerCreditManager = new ConsumerCreditManager();

            //consumerCreditManager.Calculate();

            //HousingCreditManager housingCreditManager=new HousingCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();

            //housingCreditManager.Calculate();

            //VehicleCreditManager vehicleCreditManager=new VehicleCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.Calculate();
            
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            RecourseManager recourseManager = new RecourseManager();
            recourseManager.getRecourse(consumerCreditManager,databaseLoggerService);
            recourseManager.getRecourse(housingCreditManager,fileLoggerService);
            //recourseManager.getRecourse(housingCreditManager);
            //recourseManager.getRecourse(vehicleCreditManager);
           
            
            List<ICreditManager> credits = new List<ICreditManager>()
                {housingCreditManager,vehicleCreditManager };
           // recourseManager.MakeALoanPreinformaiton(credits);

        }
    }
}

