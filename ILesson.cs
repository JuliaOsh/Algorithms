﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    interface ILesson
    {
        public string LessonID { get; set; }
        public string LessonDescription { get; set; }
    }
}