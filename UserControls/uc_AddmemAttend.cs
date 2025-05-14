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
    public partial class uc_AddmemAttend : UserControl
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragControlPoint;
        public uc_AddmemAttend()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(uc_AddmemAttend_MouseDown);
            this.MouseMove += new MouseEventHandler(uc_AddmemAttend_MouseMove);
            this.MouseUp += new MouseEventHandler(uc_AddmemAttend_MouseUp);
        }

        private void labMsCloseAttend7_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void uc_AddmemAttend_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragControlPoint = this.Location;
        }

        private void uc_AddmemAttend_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragControlPoint, new Size(diff));
            }
        }

        private void uc_AddmemAttend_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
