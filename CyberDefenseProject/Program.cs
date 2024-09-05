using CyberDefenseProject;
using System.Text.Json;
public class Program
{
    public static void Main(string[] args)
    {
        //חילוץ הקובץ לליסט של אוביקטים מהסוג של הגנות
        string jsonPathProtection = "defenceStrategiesBalanced.json";
        string jsonStringProtection = File.ReadAllText(jsonPathProtection);
        List<NodeDefense> RootNodesProtection = JsonSerializer.Deserialize<List<NodeDefense>>(jsonStringProtection);

        //חילוץ הקובץ לליסט של אוביקטים מהסוג של התקפות
        string jsonPathAttack = "threats.json";
        string jsonStringAttack = File.ReadAllText(jsonPathAttack);
        List<Attack> RootNodesAttack = JsonSerializer.Deserialize<List<Attack>>(jsonStringAttack);

       //בונה עץ של הגנות
        BinaryTree tree = new BinaryTree();
        for (int i = 0; i < RootNodesProtection.Count; i++)
        {
            tree.Insert(RootNodesProtection[i]);
        }
        //tree.PrintTree();
        Console.WriteLine(RootNodesProtection.Count);
      

        

        }
}