﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.Question
{
    public class MatchingQ : Question
    {
        //List<string> MatchingPairs = new List<string>();
        //string[,] pairsArr = new string[5, 2]; // Using a 2D array, this method was easier to implement with a matching quiz
        ////string machingQuestion;

        ////public MatchingQ(List<string> matchingPairs, string[,] pairsArr, string machingQuestion)
        ////{
        ////    this.MatchingPairs = matchingPairs;
        ////    this.pairsArr = pairsArr;
        ////    this.machingQuestion = machingQuestion;
        ////}

        List<string> left = new List<string>();
        List<string> right = new List<string>();

        public List<string> GetRight()
        {
            return right;
        }
        public List<string> GetLeft()
        {
            return left;
        }

        public MatchingQ(string question, List<string> answer, List<string> left, List<string> right) : base(question, answer)
        {
            this.left = left;
            this.right = right;
        }
    }
}
