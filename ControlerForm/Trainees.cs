using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlerForm
{
    public partial class Trainees : Form
    {
        List<Student> students;
        List<Student> stdCheck = new List<Student>();

        Labs lab1 = new Labs() { Name = "Lab1" };
        Labs lab2 = new Labs() { Name = "Lab2" };

        List<Labs> labs;//= new List<Labs>(2) { lab1, lab2 };

        public Trainees()
        {
            InitializeComponent();
            FillListTrainees();
            FillComboxLab();
        }

        private void FillListTrainees()
        {
            students = new List<Student>()
            {
                new Student(){ID = 1, Name = "Ahmed"},
                new Student(){ID = 2, Name = "Ali"},
                new Student(){ID = 3, Name = "Syed"},
                new Student(){ID = 4, Name = "Muhammed"},
                new Student(){ID = 5, Name = "Peter"},
                new Student(){ID = 6, Name = "Hosam"},
                new Student(){ID = 7, Name = "Hany"},
                new Student(){ID = 8, Name = "Haithem"}
            };

            foreach (Student item in students)
            {
                cklboxTrainees.Items.Add(item);
            }

            cklboxTrainees.DisplayMember = "Name";
        }


        private void FillComboxLab()
        {
            labs = new List<Labs>() { lab1, lab2 };

            cmboxLab.DataSource = labs;
            cmboxLab.DisplayMember = "Name";
        }

        //Add Cheched item to CkechListLab
        private void AddItemToCheckListLab(CheckedListBox from, CheckedListBox to)
        {
            foreach (Student item in stdCheck)
            {
                to.Items.Add(item);
                from.Items.Remove(item);
            }
            to.DisplayMember = "Name";
        }

        //Add Student To lab
        private void AddStudentToLab()
        {
            foreach (Labs item in labs)
            {
                if (item.Name == cmboxLab.Text)
                {
                    item.students = stdCheck;
                    break;
                }
            }
        }

        //Remove Student from lab
        private void RemoveStudentToLab()
        {
            //stdCheck.Remove()
            foreach (Labs item in labs)
            {
                if (item.Name == cmboxLab.Text && item.students != null)
                {
                    foreach (Student std in item.students.ToList())
                    {
                        item.students.Remove(std);
                    }
                    
                    break;
                }
            }
        }



        private void btnTrnToLab_Click(object sender, EventArgs e)
        {
            AddItemToCheckListLab(cklboxTrainees,cklboxLab);
            AddStudentToLab();

            stdCheck = new List<Student>();
        }

        private void cklboxTrainees_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            stdCheck.Add((Student)cklboxTrainees.SelectedItem);
            //new Student(){ Name = cklboxTrainees.SelectedValue.ToString() }
        }

        private void cmboxLab_SelectedIndexChanged(object sender, EventArgs e)
        {

            cklboxLab.Items.Clear();

            if (cmboxLab.SelectedIndex != -1)
            {
                //cklboxLab.ClearSelected();
                //foreach (Labs item in labs)
                //{
                //    if (item.Name == cmboxLab.Text && item.students != null)
                //    {
                //        foreach (Student std in item.students)
                //        {
                //            cklboxLab.Items.Add(std);
                //        }

                //        break;
                //    }
                //}

                labs.ForEach(lab =>
                {
                    if (lab.Name == cmboxLab.Text && lab.students != null)
                    {
                        lab.students.ForEach(std => cklboxLab.Items.Add(std));
                    }
                });

                cklboxLab.DisplayMember = "Name";
            }
        }

        private void btnAllTrnToLab_Click(object sender, EventArgs e)
        {
            foreach (Student item in cklboxTrainees.Items)
            {
                stdCheck.Add(item);
            }


            AddItemToCheckListLab(cklboxTrainees, cklboxLab);
            AddStudentToLab();

            stdCheck = new List<Student>();
            //cmboxLab.Text 
        }

        private void btnLabToTrn_Click(object sender, EventArgs e)
        {
            AddItemToCheckListLab(cklboxLab,cklboxTrainees);
            RemoveStudentToLab();

            stdCheck = new List<Student>();
        }

        private void cklboxLab_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //stdCheck = 
            stdCheck.Add((Student)cklboxLab.SelectedItem);
        }

        private void btnAllLabToTrn_Click(object sender, EventArgs e)
        {
            foreach (Student item in cklboxLab.Items)
            {
                stdCheck.Add(item);
            }


            AddItemToCheckListLab(cklboxLab, cklboxTrainees);
            RemoveStudentToLab();

            stdCheck = new List<Student>();
        }
    }
}
