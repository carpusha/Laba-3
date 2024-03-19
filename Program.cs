using ConsoleApp25;

class Program
{
    static void Main()
    {
        Vector3D v1 = new Vector3D(1.5, 2.2, 3.8);
        Vector3D v2 = new Vector3D(4.4, 5.5, 6.3);

        Vector3D sum = v1.Add(v2);
        Vector3D diff = v1.Subtract(v2);
        double dotProduct = v1.DotProduct(v2);
        double magnitudeV1 = v1.Magnitude();
        double cosBetween = v1.CosineBetween(v2);
        double magnitudeV2 = v2.Magnitude();

        Console.WriteLine($"Сума: ({sum.X}, {sum.Y}, {sum.Z})");
        Console.WriteLine($"Різниця: ({diff.X}, {diff.Y}, {diff.Z})");
        Console.WriteLine($"Скалярний добуток: {dotProduct}");
        Console.WriteLine($"Довжина V1: {magnitudeV1}");
        Console.WriteLine($"Довжина V2:{magnitudeV2}");
        Console.WriteLine($"Косинус кута між V1 та V2: {cosBetween}");

        Console.WriteLine();

        // Серіалізація
        string filePath = @"D:\\Laba 3.txt";
        v1.SerializeToJson(filePath);
        Console.WriteLine("Вектор збережений в " + filePath);


        // Десеріалізація
        Vector3D deserializedVector = Vector3D.DeserializeFromJson(filePath);
        Console.WriteLine($"Дисерілізований Вектор: {deserializedVector.X}, {deserializedVector.Y}, {deserializedVector.Z}");
    }
}

