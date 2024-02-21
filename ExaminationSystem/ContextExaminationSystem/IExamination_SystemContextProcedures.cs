﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using ExaminationSystem.EntitiesExaminationSystem;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace ExaminationSystem.ContextExaminationSystem
{
    public partial interface IExamination_SystemContextProcedures
    {
        Task<int> SP_Assign_Student_ExamAsync(OutputParameter<int?> ExamId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_DELETE_CoursesAsync(int? CrID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_DELETE_DepartmentAsync(int? DeptID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_Delete_InstructorAsync(int? Ins_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_Delete_Instructor_CourseAsync(int? Ins_ID, int? Cr_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_DELETE_QuestionAsync(int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_DELETE_Question_ChoicesAsync(int? id, string selector, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_Delete_StudentAsync(int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_Delete_Student_CourseAsync(int? St_ID, int? Cr_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_DELETE_Student_Exam_QuestionsAsync(int? st_id, int? exam_id, int? q_id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_DeleteFrom_ExamAsync(int? TopicID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_DeleteFrom_Exam_QuestionsAsync(int? examID, int? QuestionID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_Generate_ExamAsync(string Course_Name, int? Mcq, int? TF, OutputParameter<int?> Generated_Exam_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SP_Get_Questions_and_Choices_By_ExamIDResult>> SP_Get_Questions_and_Choices_By_ExamIDAsync(int? ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SP_Get_Student_Answers_By_examID_and_studIDResult>> SP_Get_Student_Answers_By_examID_and_studIDAsync(int? examID, int? studID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SP_Get_Student_Grade_By_IDResult>> SP_Get_Student_Grade_By_IDAsync(int? ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SP_Get_Topics_By_CourseIDResult>> SP_Get_Topics_By_CourseIDAsync(int? ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SP_GetCourseName_and_NumberOFStudentsPerCourse_By_InstructorIDResult>> SP_GetCourseName_and_NumberOFStudentsPerCourse_By_InstructorIDAsync(int? ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SP_Grade_ExamResult>> SP_Grade_ExamAsync(int? stID, int? ExamID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_Insert_CoursesAsync(int? CrID, string CrName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_Insert_DepartmentAsync(string DeptName, string DeptDesc, string Loc, int? MGRID, DateTime? MGRhiredate, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_Insert_Insructor_CourseAsync(int? Ins_ID, int? Cr_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_Insert_InstructorAsync(string Ins_Name, int? Ins_Salary, string Ins_Degree, int? Dept_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_INSERT_QuestionAsync(int? id, string head, int? grade, string difficulty, string type, string model, int? course, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_INSERT_Question_ChoicesAsync(int? id, string desc, string selector, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_Insert_StudentAsync(string Name, string Email, string Phone, int? Age, string Street, string City, string Zip_Code, int? Dept_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_Insert_Student_CourseAsync(int? St_ID, int? Cr_ID, decimal? St_Grade, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_INSERT_Student_Exam_QuestionsAsync(int? st_id, int? exam_id, int? q_id, string st_ans, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SP_InsertInto_ExamResult>> SP_InsertInto_ExamAsync(string examName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_InsertInto_Exam_QuestionsAsync(int? examID, int? QuestionID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_InsertInto_TopicAsync(string TopicName, int? CourseID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_Submit_AnswersAsync(int? exam_id, int? stud_id, DataTable answersString, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_UPDATE_CoursesAsync(int? newCrID, string CrName, int? oldCrID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_UPDATE_DepartmentAsync(int? DeptID, string DeptName, string DeptDesc, string Loc, int? MGRID, DateTime? MGRhiredate, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_Update_ExamAsync(int? Cr_ID, int? examID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_Update_Exam_QuestionsAsync(int? NewExamID, int? NewQuestionID, int? OldExamID, int? OldQuestionID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_Update_InstructorAsync(int? Ins_ID, string Ins_Name, int? Ins_Salary, string Ins_Degree, int? Dept_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_Update_Instructor_CourseAsync(int? Ins_ID_OLD, int? Cr_ID_OLD, int? Ins_ID_New, int? Cr_ID_New, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_UPDATE_Question_ChoicesAsync(int? id, string old_selector, string desc, string new_selector, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_Update_StudentAsync(int? ID, string Name, string Email, int? Age, string Street, string Phone, string City, string Zip_Code, int? Dept_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_Update_Student_CourseAsync(int? oldSt_ID, int? oldCr_ID, int? newSt_ID, int? newCr_ID, decimal? St_Grade, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_UPDATE_Student_Exam_QuestionsAsync(int? st_id, int? exam_id, int? q_id, string st_ans, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_Update_TopicAsync(int? TopicID, string topicName, int? cr_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
