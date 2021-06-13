using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PIE_Project_SD
{
    public partial class AddNewDataFrom : Form
    {
        private class LayerItem
        {
            public string fullPath;
            public string name;
        }
        public AddNewDataFrom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {            
                string fullPath = ofd.FileName;
                dataItem.Items.Add(fullPath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(string name in dataItem.Items)
            {
                Form1.myMapCtrl.AddLayerFromFile(name,0);
            }
            Form1.myMapCtrl.PartialRefresh(PIE.Carto.ViewDrawPhaseType.ViewAll);
        }
    }
}
