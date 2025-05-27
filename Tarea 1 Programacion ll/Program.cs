using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_Programacion_ll
{
    internal class Program
    {
                 private static double aumento = 0;
                 private static int contOperarios = 0;
                 private static int contTecnicos = 0;
                 private static int conProfesionales = 0;
                 private static double acumOperarios = 0;
                 private static double acumTecnicos = 0;
                 private static double acumProfesionales = 0;
                 private static string continuar;




        public Program()
        {
        }

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("-----Registro de empleados-----");

            Console.WriteLine("Ingrese la cedula: ");
            string cedula = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine();

            int tipoEmpleado;
            do
            {
                Console.WriteLine("Ingrese el tipo de empleado (1: Operario, 2: Tecnico, 3: Profesional): ");
                tipoEmpleado = int.Parse(Console.ReadLine());
            } while (tipoEmpleado < 1 || tipoEmpleado > 3);

            Console.WriteLine("Cantidad de horas laborales: ");
            double horasLaborales = double.Parse(Console.ReadLine());

            Console.WriteLine("Precio por hora: ");
            double precioHora = double.Parse(Console.ReadLine());

            double salarioOrdinario = horasLaborales * precioHora;
            double salarioExtra = 0;

            switch (tipoEmpleado)
            {
                case 1: aumento = salarioOrdinario * 0.15; // Operario
                    break;
                case 2: aumento = salarioOrdinario * 0.10; // Tecnico
                    break;
                case 3: aumento = salarioOrdinario * 0.055; // Profesional
                    break;
            }

            double salarioBruto = salarioOrdinario + aumento;
            double deduccionCCSS = salarioBruto * 0.0917; // Deducción de la CCSS
            double salarioNeto = salarioBruto - deduccionCCSS;

            // Datos del empleado
            Console.WriteLine("\n-----Datos del empleado-----");
            Console.WriteLine($"Cedula: {cedula}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Tipo de empleado: {(tipoEmpleado == 1 ? "Operario" : tipoEmpleado == 2 ? "Tecnico" : "Profesional")}");
            Console.WriteLine($"Horas laborales: {horasLaborales}");
            Console.WriteLine($"Precio por hora: {precioHora:C}");
            Console.WriteLine($"Salario ordinario: {salarioOrdinario:C}");
            Console.WriteLine($"Aumento: {aumento:C2}");
            Console.WriteLine($"Salario bruto: {salarioBruto:C}");
            Console.WriteLine($"Deducción CCSS: {deduccionCCSS:C}");
            Console.WriteLine($"Salario neto: {salarioNeto:C}");

            // Acomuladores por tipo de empleado

            switch (tipoEmpleado)
            {
                case 1:
                    contOperarios++;
                    acumOperarios += salarioNeto;
                    break;
                case 2:
                    contTecnicos++;
                    acumTecnicos += salarioNeto;
                    break;
                case 3:
                    conProfesionales++;
                    acumProfesionales += salarioNeto;
                    break;
            }

            Console.WriteLine("\nDesea registrar otro empleado? (s/n)");
            continuar = Console.ReadLine().ToLower();
        }
}
}
