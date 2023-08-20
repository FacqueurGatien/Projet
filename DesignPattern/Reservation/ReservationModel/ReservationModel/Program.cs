namespace SalleDeReunionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"+ "\n_______________________________________\n");
            IMediateur mediateur = new Mediateur();

            SalleDeReunion s1 = new SalleDeReunion(mediateur, "Atic", 50, new List<EnumEquipement>() { EnumEquipement.Climatisation, EnumEquipement.Insonorisation });
            SalleDeReunion s2 = new SalleDeReunion(mediateur, "Polar", 10, new List<EnumEquipement>() { EnumEquipement.Climatisation, EnumEquipement.VideoProjecteur, EnumEquipement.Ordinateur });
            SalleDeReunion s3 = new SalleDeReunion(mediateur, "Saturn", 100, new List<EnumEquipement>() { EnumEquipement.Climatisation });
            SalleDeReunion s4 = new SalleDeReunion(mediateur, "Gonzales", 25, new List<EnumEquipement>() { EnumEquipement.Insonorisation, EnumEquipement.Ordinateur, EnumEquipement.VideoProjecteur });

            Employee e1 = new Employee(mediateur, "ESTJ001", "AAA", "AAAAAAA");
            Employee e2 = new Employee(mediateur, "ESTJ002", "BBB", "BBBBBBB");
            Employee e3 = new Employee(mediateur, "ESTJ003", "CCC", "CCCCCCC");
            Employee e4 = new Employee(mediateur, "ESTJ004", "DDD", "DDDDDDD");
            Employee e5 = new Employee(mediateur, "ESTJ005", "EEE", "EEEEEEE");
            Employee e6 = new Employee(mediateur, "ESTJ006", "FFF", "FFFFFFF"); 

            ((Mediateur)mediateur).Salles.AddRange(new List<SalleDeReunion>() { s1, s2, s3, s4 });
            ((Mediateur)mediateur).Employees.AddRange(new List<Employee>() { e1, e2, e3, e4, e5, e6 });

            e1.ReserverSalle(new Periode(new DateTime(2023, 12, 31, 10, 0, 0), new DateTime(2023, 12, 31, 22, 0, 0)),new List<EnumEquipement> { EnumEquipement.Climatisation },20);
            e1.ReserverSalle(new Periode(new DateTime(2024, 1, 1, 8, 30, 0), new DateTime(2024, 1, 1, 12, 0, 0)), new List<EnumEquipement> { EnumEquipement.Climatisation }, 20);
            e2.ReserverSalle(new Periode(new DateTime(2024, 1, 1, 7, 30, 0), new DateTime(2024, 1, 1, 10, 0, 0)), new List<EnumEquipement> { EnumEquipement.Ordinateur }, 10);
            e3.ReserverSalle(new Periode(new DateTime(2024, 1, 1, 7, 30, 0), new DateTime(2024, 1, 1, 10, 0, 0)), new List<EnumEquipement> { EnumEquipement.Ordinateur }, 10);
            e4.ReserverSalle(new Periode(new DateTime(2024, 1, 1, 7, 30, 0), new DateTime(2024, 1, 1, 10, 0, 0)), new List<EnumEquipement> { EnumEquipement.Ordinateur }, 10);

            Console.WriteLine(((Mediateur)mediateur).ToStringReservation());

            e1.AnnulerReservation(new Periode(new DateTime(2023, 12, 31, 10, 0, 0), new DateTime(2023, 12, 31, 22, 0, 0)));
            e2.AnnulerReservation(new Periode(new DateTime(2024, 1, 1, 7, 30, 0), new DateTime(2024, 1, 1, 10, 0, 0)));
            e3.AnnulerReservation(new Periode(new DateTime(2024, 1, 1, 7, 30, 0), new DateTime(2024, 1, 1, 10, 0, 0)));
            e4.AnnulerReservation(new Periode(new DateTime(2024, 1, 1, 7, 30, 0), new DateTime(2024, 1, 1, 10, 0, 0)));

            Console.WriteLine(((Mediateur)mediateur).ToStringReservation());

            //Console.WriteLine(((Mediateur)mediateur).ToStringSalles()+ "_______________________________________\n\n\n" + ((Mediateur)mediateur).ToStringEmployees() + "\n_______________________________________\n");


        }
    }
}