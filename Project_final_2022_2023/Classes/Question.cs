﻿namespace Project_final_2022_2023.Classes
{
    internal class Question
    {
        public string QType { get; set; }
        public string QText { get; set; }
        public string QTip { get; set; }
        public List<String[]> QAnswers { get; set; }
        public String[] QCorrectAns { get; set; }
        public int QTimeLimit { get; set; }
        public int QTimeRemaining { get; set; }

        public void OpenQuestion()
        {

        }

        public void CloseQuestion()
        {

        }

        public void CountdownQuestion()
        {

        }
    }
}