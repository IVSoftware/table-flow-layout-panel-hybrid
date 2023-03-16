using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace table_flow_layout_panel_hybrid
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            buttonAdd.Click += onClickAdd;
            _spacingA = tableLayoutPanel.Top - flowLayoutPanel.Bottom;
            _spacingB = Height - tableLayoutPanel.Bottom;
            tableLayoutPanel.Anchor = (AnchorStyles)0xF;
            tableLayoutPanel.SizeChanged += (sender, e) =>bindSpacing();
            flowLayoutPanel.SizeChanged += (sender, e) =>bindSpacing();
        }
        private void bindSpacing()
        {
            tableLayoutPanel.Anchor = AnchorStyles.None;
            tableLayoutPanel.Top = flowLayoutPanel.Bottom + _spacingA;
            Height = tableLayoutPanel.Bottom + _spacingB;
            tableLayoutPanel.Anchor = (AnchorStyles)0xF;
        }

        private readonly int _spacingA;
        private readonly int _spacingB;

        private void onClickAdd(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Add(new UserControlKVP());
        }
    }
}
