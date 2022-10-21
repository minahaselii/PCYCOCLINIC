using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PsycoClinic.Domain.Entities.Question
{
    public class Question
    {

        public int Id { get; set; }
        public int TestId { get; set; }

        public String QuestionTitle { get; set; }
        //list of 4 or more option for each question
        // ۱ ۲ ۳ ۴ ۵
        [NotMapped]
        public static Dictionary<byte, string> AnswerList = new Dictionary<byte, string>
            {
                { 1,"کاملا موافقم" },
                { 2,"موافقم" },
                { 3,"نظری ندارم" },
                {4,"مخالفم" },
                {5,"کاملا مخالفم" }

            };


    }
}

