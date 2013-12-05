using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PigManagerSystem
{
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(MemberForm_Load);
        }

        void MemberForm_Load(object sender, EventArgs e)
        {
            InitGridType();
        }

        private void InitGridType()
        {

            List<StudentClass> stuList = new List<StudentClass>()
            {
                new StudentClass(){ID=1,Name="Wikey",Sex="男",Age=25,School="广东金融学院",Class="081541151",MathScroe=70,ChineseScroe=70,ComputerScroe=70,EnglishScore=70,SumScroe=280},
                new StudentClass(){ID=2,Name="Wikey",Sex="男",Age=24,School="广东金融学院",Class="081541151",MathScroe=70,ChineseScroe=70,ComputerScroe=70,EnglishScore=70,SumScroe=280},
                new StudentClass(){ID=3,Name="Wikey",Sex="男",Age=23,School="广东金融学院",Class="081541151",MathScroe=70,ChineseScroe=70,ComputerScroe=70,EnglishScore=70,SumScroe=280},
                new StudentClass(){ID=4,Name="Wikey",Sex="男",Age=26,School="广东金融学院",Class="081541151",MathScroe=70,ChineseScroe=70,ComputerScroe=70,EnglishScore=70,SumScroe=280},
                new StudentClass(){ID=5,Name="Wikey",Sex="男",Age=23,School="广东金融学院",Class="081541151",MathScroe=70,ChineseScroe=70,ComputerScroe=70,EnglishScore=70,SumScroe=280},
                new StudentClass(){ID=6,Name="Wikey",Sex="男",Age=27,School="广东金融学院",Class="081541151",MathScroe=70,ChineseScroe=70,ComputerScroe=70,EnglishScore=70,SumScroe=280},
                new StudentClass(){ID=7,Name="Wikey",Sex="男",Age=28,School="广东金融学院",Class="081541151",MathScroe=70,ChineseScroe=70,ComputerScroe=70,EnglishScore=70,SumScroe=280},
                new StudentClass(){ID=8,Name="Wikey",Sex="男",Age=21,School="广东金融学院",Class="081541151",MathScroe=70,ChineseScroe=70,ComputerScroe=70,EnglishScore=70,SumScroe=280},
                new StudentClass(){ID=9,Name="Wikey",Sex="男",Age=22,School="广东金融学院",Class="081541151",MathScroe=70,ChineseScroe=70,ComputerScroe=70,EnglishScore=70,SumScroe=280},
                new StudentClass(){ID=10,Name="Wikey",Sex="男",Age=23,School="广东金融学院",Class="081541151",MathScroe=70,ChineseScroe=70,ComputerScroe=70,EnglishScore=70,SumScroe=280},
                new StudentClass(){ID=11,Name="Wikey",Sex="男",Age=24,School="广东金融学院",Class="081541151",MathScroe=70,ChineseScroe=70,ComputerScroe=70,EnglishScore=70,SumScroe=280},
                new StudentClass(){ID=12,Name="Wikey",Sex="男",Age=22,School="广东金融学院",Class="081541151",MathScroe=70,ChineseScroe=70,ComputerScroe=70,EnglishScore=70,SumScroe=280},
                new StudentClass(){ID=13,Name="Wikey",Sex="男",Age=29,School="广东金融学院",Class="081541151",MathScroe=70,ChineseScroe=70,ComputerScroe=70,EnglishScore=70,SumScroe=280},
                new StudentClass(){ID=14,Name="Wikey",Sex="男",Age=22,School="广东金融学院",Class="081541151",MathScroe=70,ChineseScroe=70,ComputerScroe=70,EnglishScore=70,SumScroe=280},
                new StudentClass(){ID=15,Name="Wikey",Sex="男",Age=21,School="广东金融学院",Class="081541151",MathScroe=70,ChineseScroe=70,ComputerScroe=70,EnglishScore=70,SumScroe=280},
                new StudentClass(){ID=16,Name="Wikey",Sex="男",Age=25,School="广东金融学院",Class="081541151",MathScroe=52,ChineseScroe=70,ComputerScroe=70,EnglishScore=70,SumScroe=280},
            };

            for (int i = 0; i < 200; i++)
            {
                stuList.Add(new StudentClass() { ID = i, Name = "Wikey", Sex = "男", Age = 25, School = "广东金融学院", Class = "081541151", MathScroe = 70, ChineseScroe = 70, ComputerScroe = 70, EnglishScore = 70, SumScroe = 280 });
            }

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("ID", "编号");
            dataGridView1.Columns.Add("Name", "名字");
            dataGridView1.Columns.Add("Sex", "性别");
            dataGridView1.Columns.Add("Age", "年龄");
            dataGridView1.Columns.Add("School", "学校");

            dataGridView1.Columns.Add("Class", "班级");
            dataGridView1.Columns.Add("MathScroe", "数学成绩");
            dataGridView1.Columns.Add("ChineseScroe", "语文成绩");
            dataGridView1.Columns.Add("ComputerScroe", "计算机成绩");
            dataGridView1.Columns.Add("EnglishScore", "英语成绩");
            dataGridView1.Columns.Add("SumScroe", "总成绩");
            var btn1 = new DataGridViewButtonColumn()
            {
                Text = "编辑",
                UseColumnTextForButtonValue = true
            };
            var btn2 = new DataGridViewButtonColumn()
            {
                Text = "查看",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.AddRange(btn1);
            dataGridView1.Columns.AddRange(btn2);
            dataGridView1.Columns[12].HeaderText = "操作";
            dataGridView1.DataSource = stuList;
            dataGridView1.Columns[1].DataPropertyName = "ID";
            dataGridView1.Columns[2].DataPropertyName = "Name";
            dataGridView1.Columns[3].DataPropertyName = "Sex";
            dataGridView1.Columns[4].DataPropertyName = "Age";
            dataGridView1.Columns[5].DataPropertyName = "School";
            dataGridView1.Columns[6].DataPropertyName = "Class";
            dataGridView1.Columns[7].DataPropertyName = "MathScroe";
            dataGridView1.Columns[8].DataPropertyName = "ChineseScroe";
            dataGridView1.Columns[9].DataPropertyName = "ComputerScroe";
            dataGridView1.Columns[10].DataPropertyName = "EnglishScore";
            dataGridView1.Columns[11].DataPropertyName = "SumScroe";

        }
    }
}
