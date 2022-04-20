using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRating.EntityClasses;

namespace AppRating
{
    static class Program
    {
        public static ApplicationContext Context { get; set; }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            inicializeDB();
            Context = new ApplicationContext(new FormAutorization());
            Application.Run(Context);
        }

        //Заполнение тестовыми данными при первом запуске
        static void inicializeDB()
        {
            using (EntityContext db = new EntityContext())
            {
                //если БД существует-пропускаем
                if (db.Database.Exists())
                    return;

                //создаём два объекта Class
                Class class1 = new Class { Name = "5Б" };
                Class class2 = new Class { Name = "6А" };
                Class class3 = new Class { Name = "11Г" };
                Class class4 = new Class { Name = "1А" };
                Class class5 = new Class { Name = "2В" };
               

                db.Classes.Add(class1);
                db.Classes.Add(class2);
                db.Classes.Add(class3);
                db.Classes.Add(class4);
                db.Classes.Add(class5);

                //создаём два объекта Student
                Student student1 = new Student { fullName = "Иванов И.И.", address = "Под мостом", currentClass=class1 };
                Student student2 = new Student { fullName = "Петров И.И.", address = "Где-то", currentClass = class2 };
                Student student3 = new Student { fullName = "Сидоров И.И.", address = "-", currentClass = class3 };
                Student student4 = new Student { fullName = "Смирнов И.И.", address = "Пушкина", currentClass = class4 };
                Student student5 = new Student { fullName = "Козлов И.И.", address = "Колотушкина", currentClass = class5 };

                db.Students.Add(student1);
                db.Students.Add(student2);
                db.Students.Add(student3);
                db.Students.Add(student4);
                db.Students.Add(student5);

                // создаем два объекта User
                User user1 = new User { login = "Admin", password = "Admin", typeUser = User.TypeUser.Admin };
                User user2 = new User { login = "User", password = "User", typeUser = User.TypeUser.User,student=student1 };

                // добавляем их в бд
                db.Users.Add(user1);
                db.Users.Add(user2);

                ExamInfo examInfo1 = new ExamInfo(new List<Class> { class1, class2 }, new DateTime(2022, 1, 15), "Физика") ;
                ExamInfo examInfo2 = new ExamInfo(new List<Class> { class1 }, new DateTime(2022, 1, 15), "Математика");
                ExamInfo examInfo3 = new ExamInfo(new List<Class> { class1 , class4 }, new DateTime(2022, 1, 15), "Химия");

                foreach (var ei in new List<ExamInfo> { examInfo1, examInfo2 })
                {
                    foreach (var cl in ei.Classes)
                    {
                        var students = db.Students.Where(s => s.currentClass.Name == cl.Name).ToList();
                        ExamInfoClasses examInfoClasses = new ExamInfoClasses {@class=cl,exam=ei};
                        db.ExamInfoClasses.Add(examInfoClasses);
                    }
                }
                    

                db.ExamInfos.Add(examInfo1);
                db.ExamInfos.Add(examInfo2);
                

                db.SaveChanges();

                // получаем объекты из бд и выводим на консоль


            };

        }

        
    }
}
