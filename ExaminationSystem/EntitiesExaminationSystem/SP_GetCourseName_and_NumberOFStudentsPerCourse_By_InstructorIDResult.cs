﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.EntitiesExaminationSystem
{
    public partial class SP_GetCourseName_and_NumberOFStudentsPerCourse_By_InstructorIDResult
    {
        [Column("Course Name")]
        public string CourseName { get; set; }
        [Column("Number OF Students")]
        public int? NumberOFStudents { get; set; }
    }
}
