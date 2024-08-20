﻿namespace SoftwareQuizAPI.Models
{
    public class Question
    {
       
            public int Id { get; set; }
            public string QuestionText { get; set; }
            public List<string> Options { get; set; }
            public string CorrectAnswer { get; set; }
            public string Category { get; set; } 
         

    }
}
