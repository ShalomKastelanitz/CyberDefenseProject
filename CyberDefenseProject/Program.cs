using CyberDefenseProject;
using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        string jsonPath = "defenceStrategiesBalanced.json";
        string jsonString = File.ReadAllText(jsonPath);
        List<NodeDefense> rootNodes = JsonSerializer.Deserialize<List<NodeDefense>>(jsonString);


        Console.WriteLine($"Current directory: {Directory.GetCurrentDirectory()}");
        BinaryTree tree = new BinaryTree();
        for (int i = 0; i < rootNodes.Count; i++)
        {
            tree.Insert(rootNodes[i]);
        }
        tree.PrintTree();
         Console.WriteLine(rootNodes.Count);
    }
}