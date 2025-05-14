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
    public partial class ucAddPayment : UserControl
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragControlPoint;
        public ucAddPayment()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(ucAddPayment_MouseDown);
            this.MouseMove += new MouseEventHandler(ucAddPayment_MouseMove);
            this.MouseUp += new MouseEventHandler(ucAddPayment_MouseUp);
        }

        private void ucAddPayment_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ucAddPayment_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragControlPoint = this.Location;
        }

        private void ucAddPayment_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragControlPoint, new Size(diff));
            }
        }

        private void ucAddPayment_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
