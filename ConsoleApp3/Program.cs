using System;
using ConsoleApp3.Entidades;
using ConsoleApp3.Entidades.Exeções;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            try //tenta executar o bloco
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reserva reserva = new Reserva(number, checkIn, checkOut); //instanciar reserva
                Console.WriteLine("Reserva: " + reserva); //mostrar reserva

                Console.WriteLine();
                Console.WriteLine("Entre com data para atualizar a reserva: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;

                reserva.UpdateDates(checkIn, checkOut); //atualiza a reserva 
                Console.WriteLine("Reserva: " + reserva);
            }
            catch (DominExeções e) //executa, se não conseguir executar o bloco try
            {
                Console.WriteLine("Error na reserva: " + e.Message);
            }

        }
    }
}
