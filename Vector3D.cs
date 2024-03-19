using System;
using System.Text.Json;

namespace ConsoleApp25
{
    internal class Vector3D
    {
        private double x, y, z;

        public Vector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double X => x;
        public double Y => y;
        public double Z => z;

        public Vector3D Add(Vector3D v)
        {
            return new Vector3D(x + v.x, y + v.y, z + v.z);
        }

        public Vector3D Subtract(Vector3D v)
        {
            return new Vector3D(x - v.x, y - v.y, z - v.z);
        }

        public double DotProduct(Vector3D v)
        {
            return x * v.x + y * v.y + z * v.z;
        }

        public double Magnitude()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public double CosineBetween(Vector3D v)
        {
            return (DotProduct(v) / (Magnitude() * v.Magnitude()));
        }

        public void SerializeToJson(string filePath)
        {
            string json = JsonSerializer.Serialize(this);
            File.WriteAllText(filePath, json);
        }

        public static Vector3D DeserializeFromJson(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<Vector3D>(json);
        }

    }
}

