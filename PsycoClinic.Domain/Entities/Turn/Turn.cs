using System;
namespace PsycoClinic.Domain.Entities.Turn
{
    public class Turn
    {

        public int Id { get; set; }
        public int DrId { get; set; }
        public int UserId { get; set; }

        public DateTime Date { get; set; }
        public bool IsReserved { get; set; }


    }
}

