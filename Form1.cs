namespace DunGen
{
    public partial class DunGenForm : Form
    {
        Size client = new();  //client size of our form
        int mapwide, maphigh; //size of the map
        Size mazesize = new(); //size of the maze
        Bitmap cornerul = new(1, 1); //the bitmaps we'll use for our map
        Bitmap cornerur = new(1, 1); //we set them to 1,1 for now, but they
        Bitmap cornerbl = new(1, 1); //will be recreated at bits per unit
        Bitmap cornerbr = new(1, 1); //square size later
        Bitmap wallv = new(1, 1);
        Bitmap wallh = new(1, 1);
        Bitmap door = new(1, 1);
        Bitmap passage = new(1, 1);
        bool isclosing = false; //used to keep from spamming with the verification of closing
        readonly Color backcolor = Color.Silver; //colors used in map
        readonly Color roomback = Color.White;
        readonly Color roomfore = Color.Black;
        readonly Color passcolor = Color.Gray;

        public DunGenForm()
        {
            InitializeComponent(); //windows requirement
        }

        private void DG_Load(object sender, EventArgs e)
        {
            client = ClientSize = new Size(800, 500); //forces a resize to fix positions of controls
        }

        private void DG_Resize(object sender, EventArgs e)
        {
            client = ClientSize; //save the client size
            int border = 5; //set border to 5
            int high = (client.Height - numericUpDown1.Height * 7 - button1.Height * 2 - border * 2) / 9; //compute inbetween height
            panel1.Location = new(border, border); //set panel location
            panel1.Size = new(panel1.Width, client.Height - 2 * border); //set size
            label1.Location = new(border, border); //set label location
            numericUpDown1.Location = new(120, border); //and on and on
            label2.Location = new(border, numericUpDown1.Bottom + high);
            numericUpDown2.Location = new(120, label2.Top);
            label3.Location = new(border, numericUpDown2.Bottom + high);
            numericUpDown3.Location = new(120, label3.Top);
            label4.Location = new(border, numericUpDown3.Bottom + high);
            numericUpDown4.Location = new(120, label4.Top);
            label5.Location = new(border, numericUpDown4.Bottom + high);
            numericUpDown5.Location = new(120, label5.Top);
            label6.Location = new(border, numericUpDown5.Bottom + high);
            numericUpDown6.Location = new(120, label6.Top);
            label7.Location = new(border, numericUpDown6.Bottom + high);
            numericUpDown7.Location = new(120, label7.Top);
            button1.Location = new(border, numericUpDown7.Bottom + high);
            button2.Location = new(border, button1.Bottom + high);
            panel2.Location = new(panel1.Width + 2 * border, border);
            panel2.Size = new(client.Width - 3 * border - panel1.Width, client.Height - 2 * border);
        }

        private void DG_Generate(object sender, EventArgs e)
        {
            int count = (int)numericUpDown1.Value; //get values from numeric up down controls
            int minw = (int)numericUpDown2.Value;
            int maxw = (int)numericUpDown3.Value;
            int minh = (int)numericUpDown4.Value;
            int maxh = (int)numericUpDown5.Value;
            int bpu = (int)numericUpDown6.Value;
            int perch = (int)numericUpDown7.Value;
            int mapw = maxw * count; //width is room max width * count
            int maph = maxh * count; //height is room max height * count
            Generator g = new(count, minw, minh, maxw, maxh, mapw, maph, perch); //send to generator for new map
            List<Room>? rooms = g.GetRooms(); //get list of rooms
            List<Door>? doors = g.GetDoors(); //get list of doors
            List<Passage>? passages = g.GetPassages(); //get list of passages
            mapwide = g.MapWide; //get map width (should = mapw)
            maphigh = g.MapHigh; //get map height (should = maph)
            MakePictures(bpu); //make pictures
            mazesize = new(mapwide * bpu, maphigh * bpu); //set maze size
            Bitmap bmp = new(mazesize.Width, mazesize.Height); //make bitmap
            pictureBox1.Size = new(bmp.Width, bmp.Height); //set picturebox size
            if (rooms == null || doors == null || passages == null) return; //if we are missing rooms, doors, or passages, return
            using Graphics gb = Graphics.FromImage(bmp); //get graphics object for bitmap
            {
                gb.Clear(backcolor); //clear to background color
                foreach (Passage pass in passages) //for each passage
                    foreach (Point p in pass.Points) //for each point in passage
                        gb.DrawImage(passage, p.X * bpu, p.Y * bpu, bpu, bpu); //draw the passage
                foreach (Room r in rooms) //for each room
                {
                    SolidBrush rbb = new(roomback); //set brush for room insides
                    gb.FillRectangle(rbb, r.X * bpu + bpu / 2, r.Y * bpu + bpu / 2, (r.Wide - 1) * bpu, (r.High - 1) * bpu); //clear the inside of room
                    for (int y = r.Y + 1; y < r.Y + r.High - 1; y++) //for each y value
                    {
                        gb.DrawImage(wallv, r.X * bpu, y * bpu, bpu, bpu); //draw left wall
                        gb.DrawImage(wallv, (r.X + r.Wide - 1) * bpu, y * bpu, bpu, bpu); //draw right wall
                    }
                    for (int x = r.X + 1; x < r.X + r.Wide - 1; x++) //for each x value
                    {
                        gb.DrawImage(wallh, x * bpu, r.Y * bpu, bpu, bpu); //draw top wall
                        gb.DrawImage(wallh, x * bpu, (r.Y + r.High - 1) * bpu, bpu, bpu); //draw bottom wall
                    }
                    gb.DrawImage(cornerul, r.X * bpu, r.Y * bpu, bpu, bpu); //draw corners
                    gb.DrawImage(cornerur, (r.X + r.Wide - 1) * bpu, r.Y * bpu, bpu, bpu);
                    gb.DrawImage(cornerbl, r.X * bpu, (r.Y + r.High - 1) * bpu, bpu, bpu);
                    gb.DrawImage(cornerbr, (r.X + r.Wide - 1) * bpu, (r.Y + r.High - 1) * bpu, bpu, bpu);
                }
                foreach (Door d in doors) //for each door
                    gb.DrawImage(door, d.X * bpu, d.Y * bpu, bpu, bpu); //draw door
            }
            pictureBox1.Image = bmp; //set picturebox to use bitmap as its image
            pictureBox1.Invalidate(); //tell windows to refresh the picturebox
        }

        private void DG_quit(object sender, EventArgs e)
        {
            Close(); //close the window
        }
        private void DG_Closing(object sender, FormClosingEventArgs e)
        {
            if (isclosing == false) //if we are not closing (yet)
            {
                if (MessageBox.Show("Quit?  You sure?", "QUIT?", MessageBoxButtons.YesNo) == DialogResult.Yes) //if user agrees to close
                {
                    e.Cancel = false; //tell windows not to cancel closing
                    isclosing = true; //set closing flag to true
                    Application.Exit(); //exit the program
                }
                else //otherwise
                    e.Cancel = true; //tell windows to cancel the closing
            }
        }

        private void MakePictures(int bpu)
        {
            int halfbpu = bpu / 2; //set up half size (duh!)
            int penthick = bpu / 5 + 1; //set pen thickness
            Pen bpen = new(roomfore, penthick); //set up pen
            SolidBrush wbrush = new(roomback); //set up brush
            Rectangle drect = new(halfbpu / 2, halfbpu / 2, halfbpu, halfbpu); //set up door rectangle
            cornerul = MakeNewBitmap(cornerul, bpu);
            using Graphics g1 = Graphics.FromImage(cornerul); //get graphics object
            {
                g1.DrawLine(bpen, halfbpu, bpu, halfbpu, halfbpu); //draw upper left corner
                g1.DrawLine(bpen, halfbpu, halfbpu, bpu, halfbpu);
            }
            cornerur = MakeNewBitmap(cornerur, bpu);
            using Graphics g2 = Graphics.FromImage(cornerur);
            {
                g2.DrawLine(bpen, 0, halfbpu, halfbpu, halfbpu);
                g2.DrawLine(bpen, halfbpu, halfbpu, halfbpu, bpu);
            }
            cornerbl = MakeNewBitmap(cornerbl, bpu);
            using Graphics g3 = Graphics.FromImage(cornerbl);
            {
                g3.DrawLine(bpen, halfbpu, 0, halfbpu, halfbpu);
                g3.DrawLine(bpen, halfbpu, halfbpu, bpu, halfbpu);
            }
            cornerbr = MakeNewBitmap(cornerbr, bpu);
            using Graphics g4 = Graphics.FromImage(cornerbr);
            {
                g4.DrawLine(bpen, halfbpu, 0, halfbpu, halfbpu);
                g4.DrawLine(bpen, halfbpu, halfbpu, 0, halfbpu);
            }
            wallh = MakeNewBitmap(wallh, bpu);
            using Graphics g5 = Graphics.FromImage(wallh);
                g5.DrawLine(bpen, 0, halfbpu, bpu, halfbpu);
            wallv = MakeNewBitmap(wallv, bpu);
            using Graphics g6 = Graphics.FromImage(wallv);
                g6.DrawLine(bpen, halfbpu, 0, halfbpu, bpu);
            door = MakeNewBitmap(door, bpu);
            using Graphics g7 = Graphics.FromImage(door);
            {
                g7.FillRectangle(wbrush, drect);
                g7.DrawRectangle(bpen, drect);
            }
            passage = MakeNewBitmap(passage, bpu);
            using Graphics g8 = Graphics.FromImage(passage);
                g8.Clear(passcolor);
        }
        private static Bitmap MakeNewBitmap(Bitmap bmp, int bpusize)
        {
            bmp.Dispose();
            bmp = new(bpusize, bpusize);
            return bmp;
        }
    }
}