using System;
namespace PsycoClinic.Domain.Entities.Tset
{
    public class Test
    {

        public int Id { get; set; }
        public int DrId { get; set; }


        // i need to count the number of question for each test
        //public List<Question> QuestionsList { get; set; }





        public string TestName { get; set; }




        //// i need a list of categories
        //public int TestCategory { get; set; }

        //// i need a list of tets methods
        //public String TestMethod { get; set; }
    }
}

