using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        System.Drawing.Graphics g;
        System.Collections.Generic.List <Particle> particles = new System.Collections.Generic.List<Particle>();
        public Form1()
        {
            InitializeComponent();
            
            timer1.Interval = 1;
            g = pictureBox1.CreateGraphics();
            timer1.Start();

        }

        

        private void Form1_Click(object sender, EventArgs e)
        {
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //particles.Add(new Particle(new Vector2d(this.PointToClient(Cursor.Position).X, this.PointToClient(Cursor.Position).Y)));
            g.Clear(Color.White);
            for (int i = 0; i < particles.Count; i++)
            {

                particles[i].position = particles[i].position.Sum(particles[i].speed);
                if (particles[i].position.X > pictureBox1.Width)
                {
                    particles[i].speed = new Vector2d(particles[i].speed.X*-1, particles[i].speed.Y);
                }
                else if (particles[i].position.Y > pictureBox1.Height)
                {
                    particles[i].speed = new Vector2d(particles[i].speed.X, particles[i].speed.Y*-1);
                }
                else if (particles[i].position.X <= 0)
                {
                    particles[i].speed = new Vector2d(particles[i].speed.X * -1, particles[i].speed.Y);
                }
                else if(particles[i].position.Y <= 0) {
                    particles[i].speed = new Vector2d(particles[i].speed.X, particles[i].speed.Y*-1);
                }
                g.DrawRectangle(new Pen(Brushes.Black), particles[i].position.X, particles[i].position.Y, 10, 10);
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            particles.Add(new Particle(new Vector2d(this.PointToClient(Cursor.Position).X, this.PointToClient(Cursor.Position).Y)));
        }
        
        
    }
}
