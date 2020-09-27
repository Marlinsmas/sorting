using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int size;
 
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Clear();
                

                string[] mas = textBox1.Text.Split(' ');

                size = Convert.ToInt32(mas.Length);
                int[] arr = new int[size];
                for (int i = 0; i < size; i++)
                {
                    arr[i] = Convert.ToInt32(mas[i]);
                }
                int temp;
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
                for (int i = 0; i < size; i++)
                {
                    textBox2.Text += arr[i].ToString();
                    textBox2.Text += ' ';
                }

                mas = null;
                arr = null;
            }
            catch
            {
                MessageBox.Show("Заполните все необходимые поля или проверьте корректность введенных");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
          //  openFileDialog1.ShowDialog();
            filePath = openFileDialog1.FileName;
            //FileStream Fopen = new FileStream(filePath, FileMode.Open);

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                //filePath = openFileDialog1.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog1.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                    string[] mas = fileContent.Split();
                    //textBox3.Text = mas[0];
                    for (int i = 1; i < mas.Length; i++)
                    {
                        textBox1.Text += mas[i].ToString();
                        if (i != (mas.Length - 1)) textBox1.Text += ' ';
                    }
                }
            }           

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}


/*
 
static int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }                   
                }            
            }
            return mas;
        }
 */
