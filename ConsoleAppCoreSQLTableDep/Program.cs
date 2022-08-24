using System;

namespace ConsoleAppCoreSQLTableDep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=LAPTOP-EA5G5R7I\SQLEXPRESS; Initial Catalog=SQLTableDependency; Integrated Security = true;";
            using (TableDependency.SqlClient.SqlTableDependency<Modelos.Cliente> dep =
                new TableDependency.SqlClient.SqlTableDependency<Modelos.Cliente>(connectionString))
            {
                dep.OnChanged += Dep_OnChanged;
                dep.Start();

                Console.WriteLine("Presione <enter> para salir");
                Console.ReadLine();

                dep.Stop();
            }
            Console.WriteLine("Hello World!");
        }

        private static void Dep_OnChanged(object sender, TableDependency.SqlClient.Base.EventArgs.RecordChangedEventArgs<Modelos.Cliente> e)
        {
            Console.WriteLine(e.Entity.Nombres);
        }
    }
}
