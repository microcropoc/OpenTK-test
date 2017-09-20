namespace WindowsFormsApplication7gl
{
    using GL_Geometry;
    using OpenTK.Graphics.OpenGL;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        float AngleX = 0;
        float AngleY = 0;
        float AngleZ = 0;
        bool loaded = false;
        bool RotateCheckdown = false;
        Point FistPosRotateXY = new Point();
        int List1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loaded = true;
            Setting();
            GLCube CubeTest = new GLCube(40);
            List1=  CubeTest.List();


        }
        private void Setting()
        {
            GL.ClearColor(Color.White);
            int w = glControl1.Width;
            int h = glControl1.Height;
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-w / 5, w / 4,- h / 5, h / 4, -100, 200); 
            GL.Viewport(0, 0, w, h);
        }

        private void glControl1_Resize(object sender, EventArgs e)
        {
            if (!loaded)
            {
                return;
            }
        }
       
        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (!loaded)
                return;
            GL.Enable(EnableCap.DepthTest);
            GL.Clear(ClearBufferMask.ColorBufferBit|ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.Lighting);
            GL.Enable(EnableCap.Light0);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.Rotate(AngleX, 1.0, 0.0, 0.0);
            GL.Rotate(AngleY, 0.0, 1.0, 0.0);
            GL.Rotate(AngleZ, 0.0, 0.0, 1.0);
            // GLCoordinates CoordinatesTest = new GLCoordinates(glControl1.Height, false);
            // GLCube CubeTest = new GLCube(40);
            //   CoordinatesTest.Run();
            //  CubeTest.Run();
            GL.CallList(List1);
            GL.Flush();
            GL.Finish();
            glControl1.SwapBuffers();
        }

        private void glControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!RotateCheckdown)
            {
                RotateCheckdown = true;
                FistPosRotateXY = Cursor.Position;
            }
            else
            {
                RotateCheckdown = false;
            }
        }

        private void glControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (RotateCheckdown)
            {
                AngleY = Cursor.Position.X - FistPosRotateXY.X;
                AngleX = Cursor.Position.Y - FistPosRotateXY.Y;
                glControl1.Invalidate();

            }
        }
    }
}
