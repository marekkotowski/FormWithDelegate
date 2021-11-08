using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormWithDelegate
{
    public delegate void Info();
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetInfo("Rozpoczynam Program");
        }


        private void SetInfo(string _info)
        {
            this.toolStripStatusLabel1.Text = _info; 
        }

        private void btnAnaliza_Click(object sender, EventArgs e)
        {
            WorkClassModel model = new WorkClassModel();
            new Thread(() =>
            {
               model.DoAnalysis(SetInfo);
            }).Start(); 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkClassModel model = new WorkClassModel();
            new Thread(() =>
            {
                model.CheckResult(SetInfo);
            }).Start();
           
        }
    }
}
