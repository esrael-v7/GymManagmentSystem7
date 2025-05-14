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
    public partial class us_AddTrainer : UserControl
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragControlPoint;
        public us_AddTrainer()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(us_AddTrainer_MouseDown);
            this.MouseMove += new MouseEventHandler(us_AddTrainer_MouseMove);
            this.MouseUp += new MouseEventHandler(us_AddTrainer_MouseUp);
            
            }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnClosetrain34_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void us_AddTrainer_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragControlPoint = this.Location;
        }

        private void us_AddTrainer_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragControlPoint, new Size(diff));
               }
        }

        private void us_AddTrainer_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        }
}
