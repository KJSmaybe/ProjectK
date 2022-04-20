using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRating.EntityClasses
{
    //Класс описывающий учётку
    public class User
    {
        public enum TypeUser
        {
            Admin,
            User
        }

        [Key]
        public int id { get; set; }
        [Required]
        public string login { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public TypeUser typeUser { get; set; } = TypeUser.User;

        public virtual Student student { get; set; }

    }

    public class Student
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string fullName { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public Class currentClass { get; set; }
        public bool isExpelled { get; set; } = false;
        public ExpelledInfo expelledInfo { get; set; }

        public override string ToString()
        {
            return fullName;
        }
    }

    //Информация о классе ученика
    public class Class
    {
        public int id { get; set; }
        [Required]
        public string Name { get; set; }

        //public ICollection<ExamInfo> ExamInfos { get; set; }

        public Class()
        {
            // ExamInfos = new List<ExamInfo>();
        }

        public override string ToString()
        {
            return Name;
        }
    }

    //Информация об отчислении
    public class ExpelledInfo
    {
        public int id { get; set; }
        [Required]
        public DateTime dateExpelled { get; set; }
        [Required]
        public string numOrderExpelled { get; set; }
    }

    //Информация о экзаменах
    public class ExamInfo
    {
        public int id { get; set; }
        [Required]
        public DateTime dateExam { get; set; }
        [Required]
        public string name { get; set; }
        //какие классы будут сдавать экзамен
        public ICollection<Class> Classes { get; set; }
        public ExamInfo(ICollection<Class> Classes, DateTime dateExam, string name)
        {
            this.Classes = Classes;
            this.dateExam = dateExam;
            this.name = name;
        }
        public ExamInfo() { }
        public override string ToString()
        {
            return name;
        }
    }

    public class ExamInfoClasses
    {
        public int id { get; set; }
        [Required]
        public ExamInfo exam { get; set; }
        [Required]
        public Class @class { get; set; }
    }

    public class ExamResult
    {
        public int id { get; set; }
        [Required]
        public ExamInfo exam { get; set; }
        [Required]
        public Student student { get; set; }
        public int? grade { get; set; }
        
    }


    //Контекст Базы Данных
    public class EntityContext : DbContext
    {
        public EntityContext()
            : base("DbConnection")
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ExpelledInfo> ExpelledInfos { get; set; }
        public DbSet<ExamInfo> ExamInfos { get; set; }
        public DbSet<ExamResult> ExamResults { get; set; }
        public DbSet<ExamInfoClasses> ExamInfoClasses { get; set; }
        
    }


}
