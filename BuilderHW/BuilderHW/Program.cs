using System;

namespace BuilderHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VacationBuilder BuilderVaction = new DreamVacation();
            BuilderVaction.CreateVacation();
            Vacation vacation = BuilderVaction.GetVacation();
            Console.WriteLine(vacation);

            VacationBuilder BuilderVacation = new LowCostVacation();
            BuilderVacation.CreateVacation();
            Vacation vacation1 = BuilderVacation.GetVacation();
            Console.WriteLine(vacation1);


            VacationFluentBuilder vfb = new VacationFluentBuilder();
            VacationFluent vf = vfb.GetBussnessFlight().GetFancyHotel().GetPrivatShuttle().build();
        }
    }


}
