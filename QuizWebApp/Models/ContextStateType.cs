﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizWebApp.Models
{
    public enum ContextStateType
    {
        PleaseWait,
        ChooseTheAnswer,
        Closed,
        ShowCorrectAnswer
    }
}