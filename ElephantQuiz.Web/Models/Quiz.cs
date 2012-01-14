using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElephantQuiz.Web.Models
{
    public class Quiz
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public List<Question> Questions { get; set; } 

        public class Question
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public List<Answer> Answers { get; set; }

            public class Answer
            {
                public int Id { get; set; }
                public string Title { get; set; }
            }
        }
    }
}