using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagmentSystem7.UserControls
{
    public partial class uc_viewMsPlan : UserControl
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragControlPoint;
        public uc_viewMsPlan()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(uc_viewMsPlan_MouseDown);
            this.MouseMove += new MouseEventHandler(uc_viewMsPlan_MouseMove);
            this.MouseUp += new MouseEventHandler(uc_viewMsPlan_MouseUp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void uc_viewMsPlan_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragControlPoint = this.Location;
        }

        private void uc_viewMsPlan_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragControlPoint, new Size(diff));
            }
        }

        private void uc_viewMsPlan_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
