using System;
using System.Collections.Generic;

namespace IntrepreterDesignPattern
{
    class Program
    {
        static List<RoleExpression> CreateExpressionTree(string formula)
        {
            List<RoleExpression> tree = new List<RoleExpression>();

            foreach (char role in formula)
            {
                if (role == 'A')
                {
                    tree.Add(new ArchitectureExpression());
                }
                else if (role == 'S')
                {
                    tree.Add(new SeniorExpression());
                }
                if (role == 'C')
                {
                    tree.Add(new ConsultantExpression());
                }
                else if (role == 'D')
                {
                    tree.Add(new DeveloperExpression());
                }
            }

            return tree;
        }

        static void RunExpression(Context context)
        {
            foreach (RoleExpression expression in CreateExpressionTree(context.Formula))
            {
                expression.Interpret(context);
            }

            Console.WriteLine("{0} için maliyet puanı {1}", context.Formula, context.TotalPoint);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Architecture : 5, Consultant: 10, Senior:15, Developer :20");

            Context context = new Context { Formula = "ACSSDDDD" };
            RunExpression(context);


            context = new Context { Formula = "CSDD" };
            RunExpression(context);


        }
    }
}
