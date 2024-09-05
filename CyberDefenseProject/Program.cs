using CyberDefenseProject;
using System;
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
        for (int i = 0; i < RootNodesProtection.Count; i++)//o(n)
        {
            tree.Insert(RootNodesProtection[i]);
        }
        tree.PrintTree();

        
        //עובר תקיפה תקיפה ומוצא הגנות הנכונות
        foreach (Attack nodeAttac in RootNodesAttack)//o(n*m)
        {
            //מוצא את חומרת ההתקפה
            int AttackSeverity = nodeAttac.FormulaCalculatingSeverity();
            //מוצא את ההגנה
            NodeDefense Defense = tree.FindProtection(AttackSeverity);
            if (Defense != null)
            {
                Console.WriteLine(" The best defense for " + nodeAttac.ThreatType);
                Thread.Sleep(4000);
                //עובר על ליסט של סטרינג ההגנה המתאימה
                foreach (string stringDefense in Defense.Defenses)
                    Console.WriteLine(stringDefense);
                Thread.Sleep(4000);
                Console.WriteLine();
               

            }
        }

        
       

    }
    
   

}