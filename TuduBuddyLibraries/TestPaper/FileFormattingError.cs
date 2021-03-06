﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaterial
{
    public class FileFormattingError
    {
        public int QuestionNumber { get; private set; }
        public List<string> ErrorMessage { get; private set; }
        

        public FileFormattingError(int questionNumber, List<string> errorList)
        {
            this.QuestionNumber = questionNumber;

            this.ErrorMessage = new List<string>();
            this.ErrorMessage.AddRange(errorList);
        }
    }
}
