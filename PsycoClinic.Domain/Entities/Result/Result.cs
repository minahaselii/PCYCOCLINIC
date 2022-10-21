using System;
namespace PsycoClinic.Domain.Entities.Result
{
    public class Result
    {

        public int Id { get; set; }
        public string TestResult { get; set; }
        public int TestId { get; set; }
        public int UserId { get; set; }

    }
}

