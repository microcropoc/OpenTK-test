namespace GL_Geometry
{
    using OpenTK;
    using OpenTK.Graphics.OpenGL;
    using System.Drawing;

    public class GLCube
    {
        private double SizeCube { get; set; }
        public GLCube(double SizeCube = 50)
        {
            this.SizeCube = SizeCube;
        }
        public void Run()
        {
            // треугольник 1
           
           GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Diffuse, Color.HotPink);
            Vector3d a= new Vector3d();
            Vector3d b = new Vector3d();
            Vector3d c = new Vector3d();
            Vector3d side1 = new Vector3d();
            Vector3d side2 = new Vector3d();
            Vector3d normal = new Vector3d();

          //   /*
            GL.Begin(BeginMode.Triangles);
            a = new Vector3d(1, 1, 0);
            b = new Vector3d(1, SizeCube, 0);
            c = new Vector3d(SizeCube, 1, 0);
            side1 = new Vector3d(b - a);
            side2 = new Vector3d(c - a);
            normal = Vector3d.Cross(side1, side2);
            GL.Normal3(Vector3d.Normalize(normal));
            GL.Vertex3(a);
            GL.Vertex3(b);
            GL.Vertex3(c);
            GL.End();

            // треугольник 2
            GL.Begin(BeginMode.Triangles);
            a = new Vector3d(SizeCube, SizeCube, 0);
            b = new Vector3d(SizeCube, 1, 0);
            c = new Vector3d(1, SizeCube, 0);
            side1 = new Vector3d(b - a);
            side2 = new Vector3d(c - a);
            GL.Normal3(Vector3d.Normalize(normal));
            GL.Vertex3(a);
            GL.Vertex3(b);
            GL.Vertex3(c);
            GL.End();
         //    */

           //  /*
            // треугольник 3
            GL.Begin(BeginMode.Triangles);
            a = new Vector3d(SizeCube, SizeCube, 0);
            b = new Vector3d(1, SizeCube, 0);
            c = new Vector3d(1, SizeCube, SizeCube);
            side1 = new Vector3d(b - a);
            side2 = new Vector3d(c - a);
            normal = Vector3d.Cross(side1, side2);
            GL.Normal3(Vector3d.Normalize(normal));
            GL.Vertex3(a);
            GL.Vertex3(b);
            GL.Vertex3(c);
            GL.End();
       

            // треугольник 4
            GL.Begin(BeginMode.Triangles);
            a = new Vector3d(SizeCube, SizeCube, 0);
            b = new Vector3d(1, SizeCube, SizeCube);
            c = new Vector3d(SizeCube, SizeCube, SizeCube);
            side1 = new Vector3d(b - a);
            side2 = new Vector3d(c - a);
            GL.Normal3(Vector3d.Normalize(normal));
            GL.Vertex3(a);
            GL.Vertex3(b);
            GL.Vertex3(c);
            GL.End();
          //   */

         //    /*
            // треугольник 5
            GL.Begin(BeginMode.Triangles);
            a = new Vector3d(SizeCube, 1, 0);
            b = new Vector3d(SizeCube, SizeCube, 0);
            c = new Vector3d(SizeCube, SizeCube, SizeCube);
            side1 = new Vector3d(b - a);
            side2 = new Vector3d(c - a);
            normal = Vector3d.Cross(side1, side2);
            GL.Normal3(Vector3d.Normalize(normal));
            GL.Vertex3(a);
            GL.Vertex3(b);
            GL.Vertex3(c);
            GL.End();
           

            // треугольник 6
            GL.Begin(BeginMode.Triangles);
            a = new Vector3d(SizeCube, 1, 0);
            b = new Vector3d(SizeCube, 1, SizeCube);
            c = new Vector3d(SizeCube, SizeCube, SizeCube);
            side1 = new Vector3d(b - a);
            side2 = new Vector3d(c - a);
            GL.Normal3(Vector3d.Normalize(normal));
            GL.Vertex3(a);
            GL.Vertex3(b);
            GL.Vertex3(c);
            GL.End();
         //    */

          //   /*
            // треугольник 7
            GL.Begin(BeginMode.Triangles);
            a = new Vector3d(1, 1, 0);
            b = new Vector3d(SizeCube, 1, 0);
            c = new Vector3d(SizeCube, 1, SizeCube);
            side1 = new Vector3d(b - a);
            side2 = new Vector3d(c - a);
            normal = Vector3d.Cross(side1, side2);
            GL.Normal3(Vector3d.Normalize(normal));
            GL.Vertex3(a);
            GL.Vertex3(b);
            GL.Vertex3(c);
            GL.End();

            // треугольник 8
            GL.Begin(BeginMode.Triangles);
            a = new Vector3d(1, 1, 0);
            b = new Vector3d(1, 1, SizeCube);
            c = new Vector3d(SizeCube, 1, SizeCube);
            side1 = new Vector3d(b - a);
            side2 = new Vector3d(c - a);
            GL.Normal3(Vector3d.Normalize(normal));
            GL.Vertex3(a);
            GL.Vertex3(b);
            GL.Vertex3(c);
            GL.End();
          //  */

          //   /*
            // треугольник 9
            GL.Begin(BeginMode.Triangles);
            a = new Vector3d(1, 1, 0);
            b = new Vector3d(1, SizeCube, 0);
            c = new Vector3d(1, SizeCube, SizeCube);
            side1 = new Vector3d(b - a);
            side2 = new Vector3d(c - a);
            normal = Vector3d.Cross(side1, side2);
            GL.Normal3(Vector3d.Normalize(normal));
            GL.Vertex3(a);
            GL.Vertex3(b);
            GL.Vertex3(c);
            GL.End();

            // треугольник 10
            GL.Begin(BeginMode.Triangles);
            a = new Vector3d(1, 1, 0);
            b = new Vector3d(1, 1, SizeCube);
            c = new Vector3d(1, SizeCube, SizeCube);
            side1 = new Vector3d(b - a);
            side2 = new Vector3d(c - a);
            GL.Normal3(Vector3d.Normalize(normal));
            GL.Vertex3(a);
            GL.Vertex3(b);
            GL.Vertex3(c);
            GL.End();
            //   */

            // треугольник 11
            //   /*
            GL.Begin(BeginMode.Triangles);
            a = new Vector3d(SizeCube, SizeCube, SizeCube);
            b = new Vector3d(1, 1, SizeCube);
            c = new Vector3d(1, SizeCube, SizeCube);
            side1 = new Vector3d(b - a);
            side2 = new Vector3d(c - a);
            normal = Vector3d.Cross(side1, side2);
            GL.Normal3(Vector3d.Normalize(normal));
            GL.Vertex3(a);
            GL.Vertex3(b);
            GL.Vertex3(c);
            GL.End();

            // треугольник 12
            GL.Begin(BeginMode.Triangles);
            a = new Vector3d(SizeCube, 1, SizeCube);
            b = new Vector3d(SizeCube, SizeCube, SizeCube);
            c = new Vector3d(1, 1, SizeCube);
            side1 = new Vector3d(b - a);
            side2 = new Vector3d(c - a);
            GL.Normal3(Vector3d.Normalize(normal));
            GL.Vertex3(a);
            GL.Vertex3(b);
            GL.Vertex3(c);
            GL.End();
        // */
        }

        public int List()
        {
            int list1 =  GL.GenLists(1);
            GL.NewList(list1,ListMode.Compile);
            Run();
            GL.EndList();
            return list1;
        }
      }
    public class GLCoordinates
    {
        private int Size { get; set; }
        private bool Mode { get; set; }

        public GLCoordinates(int Size=400, bool Mode=false)
        {
            this.Size = Size;
            this.Mode = Mode;
        }
     
        public void Run()
        {
            for (int i = 1; i < Size; i += 2)
            {
                GL.Begin(BeginMode.Lines);
                //y
                GL.Color3(Color.Teal);
                GL.Vertex3(0, i, 0);
                GL.Vertex3(1, i, 0);
                //x
                GL.Color3(Color.Green);
                GL.Vertex3(i, 0, 0);
                GL.Vertex3(i, 1, 0);
                //z
                GL.Color3(Color.Violet);
                GL.Vertex3(0, 0, i);
                GL.Vertex3(0, 1, i);
                GL.End();
            }
            if(Mode)
            {
                for (int i = 1; i < Size; i += 2)
                {
                    GL.Begin(BeginMode.Lines);
                    //-y
                    GL.Color3(Color.Teal);
                    GL.Vertex3(0, -i, 0);
                    GL.Vertex3(1, -i, 0);
                    //-x
                    GL.Color3(Color.Green);
                    GL.Vertex3(-i, 0, 0);
                    GL.Vertex3(-i, 1, 0);
                    //-z
                    GL.Color3(Color.Violet);
                    GL.Vertex3(0, 0, -i);
                    GL.Vertex3(0, 1, -i);
                    GL.End();
                }
            }
        }
    }
    }

