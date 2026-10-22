using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramФайл3
{
    internal class Program
    {
        static void Main()
        {
         public partial class SpaceShuttle
        {
            private object _oxygenHours;
            private object _hullIntegrity;
            private object _fuelKg;

            public bool IsOperational { get; private set; }
            public object ShuttleName { get; private set; }

            partial void OnCriticalSystemAlert(string systemName, string message);

            partial void OnCriticalSystemAlert(string systemName, string message)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[ТРЕВОГА] [{systemName}] {message}");
                Console.ResetColor();
            }

            public void CheckSystems()
            {
                if (_fuelKg < 500)
                {
                    OnCriticalSystemAlert("Топливная система", "Критический остаток топлива!");
                }

                if (_hullIntegrity < 25)
                {
                    OnCriticalSystemAlert("Контур обшивки", "Опасность разрушения корпуса!");
                }
            }

            public void PrintTelemetry()
            {
                Console.WriteLine(new string('-', 50));
                Console.WriteLine($"ТЕЛЕМЕТРИЯ КОРАБЛЯ: {ShuttleName}");
                Console.WriteLine(new string('-', 50));
                Console.WriteLine($"Топливо:              {_fuelKg,10:F1} кг");
                Console.WriteLine($"Кислород:             {_oxygenHours,10:F1} ч");
                Console.WriteLine($"Прочность корпуса:    {_hullIntegrity,10} %");
                Console.WriteLine($"Статус:               {(IsOperational ? "РАБОТОСПОСОБЕН" : "НЕРАБОТОСПОСОБЕН")}");
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}