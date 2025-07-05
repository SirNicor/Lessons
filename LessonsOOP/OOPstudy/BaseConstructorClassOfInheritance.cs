namespace LessonsOOP;
        class Point2D
        {
            public Point2D()
            {
                Console.WriteLine("Point 2D Constructor");
            }

            public Point2D(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public int x { get; set; }
            public int y { get; set; }

            public void Print()
            {
                Console.WriteLine("x: " + x);
                Console.WriteLine("y: " + y);
            }
        }
    
        class Point3d:Point2D
        {
            public Point3d()
            {
                Console.WriteLine("Point 3D Constructor");
            }
            public Point3d(int x, int y, int z):base(x, y)
            {
                Console.WriteLine("Point 3D Constructor");
                this.z = z;
            }
             public int z { get; set; }

             public void Print()
             {
                 base.Print(); 
                 Console.WriteLine("z: " + z);
             }
        }
    