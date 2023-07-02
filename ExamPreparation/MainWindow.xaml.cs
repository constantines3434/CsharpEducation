using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ExamPreparation
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        List<StudentData> Students = new List<StudentData>();
        public MainWindow()
        {
            InitializeComponent();
            LoadListViewData();
        }

        private void LoadListViewData()
        {
            List<StudentData> people = new List<StudentData>
            {
         new StudentData
         {   Id = 1,
             Surname = "Смирнов",
             Name = "Константин",
             Patronymic = "Вадимович",
             MathGrade = 5,
             InfoGrade = 5,
             PhysicGrade = 5 },
            new StudentData
            {
                Id = 2,
                Surname = "Бронштейн",
                Name = "Лейба",
                Patronymic = "Давыдович",
                MathGrade = 5,
                InfoGrade = 5,
                PhysicGrade = 4
            },
            new StudentData
            {
                Id = 3,
                Surname = "Зиновьев",
                Name = "Григорий",
                Patronymic = "Евсеевич",
                MathGrade = 5,
                InfoGrade = 4,
                PhysicGrade = 4
            },
            new StudentData
            {
                Id = 4,
                Surname = "Ульянов",
                Name = "Владимир",
                Patronymic = "Ильич",
                MathGrade = 4,
                InfoGrade = 4,
                PhysicGrade = 4
            }
         };

        DataView.ItemsSource = people;

            //GridView gridView = new GridView();
            //DataView.View = gridView;

            //gridView.Columns.Add(new GridViewColumn { Header = "Id", DisplayMemberBinding = new Binding("Id") });
            //gridView.Columns.Add(new GridViewColumn { Header = "Surname", DisplayMemberBinding = new Binding("Surname") });
        }
    }
}
