﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        [Serializable]
        public class Teacher
        {
            public string FIO { get; set; }
            public string Auditory { get; set; }
            public string Department { get; set; }

            public Teacher(string FIO, string audit, string depart)
            {
                this.FIO = FIO;
                this.Auditory = audit;
                this.Department = depart;
            }
            public Teacher() { }
        }
        public List<Teacher> teach = new List<Teacher>(); 
        public Teacher teacher { get; set; }

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void SaveTeacherF2BT_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(FIOTeacherBox.Text) && !string.IsNullOrEmpty(AuditoryBox.Text) && !string.IsNullOrEmpty(DepartmentTeacherBox.Text))
            {
               // teacher.FIO = FIOTeacherBox.Text;
                //teacher.Auditory = AuditoryBox.Text;
                //teacher.Department = DepartmentTeacherBox.Text;
                teach.Add(new Teacher(FIOTeacherBox.Text, AuditoryBox.Text, DepartmentTeacherBox.Text));
                this.Close();
            }
            else
                MessageBox.Show("Заполните информацию!");
        }
    }
}
