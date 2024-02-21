﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ExaminationSystem.EntitiesExaminationSystem;

public partial class Department
{
    public int DeptId { get; set; }

    public string DeptName { get; set; }

    public string DeptDescription { get; set; }

    public string Location { get; set; }

    public int? MgrId { get; set; }

    public DateTime? MgrHireDate { get; set; }

    public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();

    public virtual Instructor Mgr { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}