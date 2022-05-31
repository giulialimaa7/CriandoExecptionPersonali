using System;
using ConsoleApp3.Entidades.Exeções;

namespace ConsoleApp3.Entidades

{
    class Reserva
    {
        public int RoomNumeber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reserva() //constrtutor sem argumento
        {
        }
        public Reserva(int roomnumber, DateTime checkIn, DateTime checkOut) //constrtutor com argumento
        {
            if (checkOut <= checkIn)// teste para saber se a data da saída é anterior a data de entrada
            {
                throw new DominExeções("Error na reserva: a data de check-out tem que ser depois da data de check-in");
            }

            RoomNumeber = roomnumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public int Duração() //lógica para calcular a duração da hospedagem
        {
            TimeSpan duração = CheckOut.Subtract(CheckIn);
            return (int)duração.TotalDays;
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut) //lógica de atualizar reserva 
        {
            DateTime now = DateTime.Now; 

            if (checkIn > now || checkOut > now) 
            {
                throw new DominExeções ("Error na reserva: as datas de atualização tem que ser datas futuras");
            }
            if (checkOut <= checkIn)
            {
                throw new DominExeções ("Error na reserva: a data de check-out tem que ser depois da data de check-in");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            
        }
        public override string ToString()
        {
            return "Room "
                + RoomNumeber
                + ", checkin: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", checkout: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duração()
                + " nights";
        }
    }
 }   