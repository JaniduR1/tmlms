﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoice
{
    public partial class UserControl1: UserControl
    {
        string questions;

        List<string> choices = new List<string>();
        public UserControl1()
        {
            InitializeComponent();
        }

        public (bool, TmLms.Question.MultipleChoiceQ) GetQandAns()
        {
            bool returnBool = false;
            TmLms.Question.MultipleChoiceQ multipleChoiceQu = new TmLms.Question.MultipleChoiceQ();

            return (returnBool, multipleChoiceQu);

            UserControl userControl = new MultipleChoice.UserControl1();

            panel1.Controls.Add(userControl);

            MultipleChoice.UserControl1 multiChoice = (MultipleChoice.UserControl1)userControl;

            multiChoice.GetQandAns();
        }

    }
}
