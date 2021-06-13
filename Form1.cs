using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIE.AxControls;
using System.Windows.Forms;
using PIE.SystemUI;
using PIE.CommonAlgo;
using PIE.SystemAlgo;
using Learing;



namespace PIE_Project_SD
{
    public partial class Form1 : Form
    {
        // ADD ToCControl
        public static TOCControl myToolCtrl = new TOCControl();
        // ADD MapControl
        public static MapControl myMapCtrl = new MapControl();
                 
        public Form1()
        {
            InitializeComponent();
            myToolCtrl.Dock = DockStyle.Fill;
            splitContainer1.Panel1.Controls.Add(myToolCtrl);

            myMapCtrl.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(myMapCtrl);
            //绑定
            myToolCtrl.SetBuddyControl(myMapCtrl);
            
            

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var addFrom = new AddNewDataFrom();
            addFrom.Show();           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var algo = AlgoFactory.Instance().CreateAlgo("Learing.dll", "Learing.DataLearning");
            algo.Name = "计算NDVI";
            //var info = new A
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
