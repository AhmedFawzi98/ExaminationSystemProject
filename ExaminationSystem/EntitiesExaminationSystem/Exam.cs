﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ExaminationSystem.EntitiesExaminationSystem;

public partial class Exam
{
    public int ExId { get; set; }

    public int? CrId { get; set; }

    public string IsAssigned { get; set; }

    public virtual Course Cr { get; set; }

    public virtual ICollection<StudentExamQuestion> StudentExamQuestions { get; set; } = new List<StudentExamQuestion>();

    public virtual ICollection<Question> QIds { get; set; } = new List<Question>();
}