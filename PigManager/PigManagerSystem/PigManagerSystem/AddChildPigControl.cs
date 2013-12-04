using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PigManagerSystem.Models;

namespace PigManagerSystem
{
    public partial class AddChildPigControl : UserControl
    {
        public AddChildPigControl()
        {
            InitializeComponent();
            this.Load += new EventHandler(AddChildPigControl_Load);

        }

        void AddChildPigControl_Load(object sender, EventArgs e)
        {
            //this.comboBox1.Items.Add("健仔");
            //this.comboBox1.Items.Add("弱仔");
            //this.comboBox1.Items.Add("死胎");
            //this.comboBox1.Items.Add("木乃伊");
            //this.comboBox1.Items.Add("木乃伊");
        }
    }
}
