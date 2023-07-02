using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    internal class StudentData
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int MathGrade { get; set; }
        public int InfoGrade { get; set; }
        public int PhysicGrade {get; set;}

        //public StudentData(int Id, string Surname, string Name, string Patronymic,
        //                   int MathGrade, int InfoGrade, int PhysicGrade)
        //{
        //    this.Id = Id;
        //    this.Surname = Surname;
        //    this.Name = Name;
        //    this.Patronymic= Patronymic;
        //    this.MathGrade = MathGrade;
        //    this.InfoGrade = InfoGrade;
        //    this.PhysicGrade = PhysicGrade;
        //}
    }
}
