using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbinarywrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\deptBinary.dat", FileMode.Create, FileAccess.Write);
                student dept = new student();
                dept.rollno = Convert.ToInt32(txtrollno.Text);
                dept.name = txtname.Text;
                dept.percentage = txtpercentage.Text;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, dept);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnbinaryread_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\deptBinary.dat", FileMode.Open, FileAccess.Read);
                student stud= new student();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                stud = (student)binaryFormatter.Deserialize(fs);
                txtrollno.Text = stud.rollno.ToString();
                txtname.Text = stud.name;
                txtpercentage.Text = stud.percentage;
                MessageBox.Show("Data saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnxmlwrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\deptXml.xml", FileMode.Create, FileAccess.Write);
                student dept = new student();
                dept.rollno = Convert.ToInt32(txtrollno.Text);
                dept.name = txtname.Text;
                dept.percentage = txtpercentage.Text;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(student));
                xmlSerializer.Serialize(fs, dept);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnxmlread_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\deptXml.xml", FileMode.Open, FileAccess.Read);
                student stud = new student();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(student));
                stud = (student)xmlSerializer.Deserialize(fs);
                txtrollno.Text = stud.rollno.ToString();
                txtname.Text = stud.name;
                txtpercentage.Text = stud.percentage;
                MessageBox.Show("Data saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnsoapwrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\deptsoap.soap", FileMode.Create, FileAccess.Write);
                student dept = new student();
                dept.rollno = Convert.ToInt32(txtrollno.Text);
                dept.name = txtname.Text;
                dept.percentage = txtpercentage.Text;
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, dept);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnsoapread_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\deptsoap.soap", FileMode.Open, FileAccess.Read);
                student dept = new student();
                SoapFormatter soapFormatter = new SoapFormatter();
                dept = (student)soapFormatter.Deserialize(fs);
                txtrollno.Text = dept.rollno.ToString();
                txtname.Text = dept.name;
                txtpercentage.Text = dept.percentage;
                MessageBox.Show("Test");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnjsonwrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\deptJson.json", FileMode.Create, FileAccess.Write);
                student dept = new student();
                dept.rollno = Convert.ToInt32(txtrollno.Text);
                dept.name = txtname.Text;
                dept.percentage = txtpercentage.Text;
                JsonSerializer.Serialize<student>(fs, dept);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnjsonread_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\deptJson.json", FileMode.Open, FileAccess.Read);
                student dept = new student();

                dept = JsonSerializer.Deserialize<student>(fs);
                txtrollno.Text = dept.rollno.ToString();
                txtname.Text = dept.name;
                txtpercentage.Text = dept.percentage;
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
