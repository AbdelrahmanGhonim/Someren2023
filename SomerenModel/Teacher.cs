﻿using System;

namespace SomerenModel
{
    public class Teacher
    {
        public int Id { get; set; }     // database id
        public string Name { get; set; }
        public int Number { get; set; } // LecturerNumber, e.g. 47198
        public DateTime DateOfBirth { get; set; }
    }
}