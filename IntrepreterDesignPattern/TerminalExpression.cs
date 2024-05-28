using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrepreterDesignPattern
{
    public class ArchitectureExpression : RoleExpression
    {
        public void Interpret(Context context)
        {
            if (context.Formula.Contains("A"))
            {
                context.TotalPoint += 5;
            }
        }
    }

    public class ConsultantExpression : RoleExpression
    {
        public void Interpret(Context context)
        {
            if (context.Formula.Contains("C"))
            {
                context.TotalPoint += 10;
            }
        }
    }

    public class SeniorExpression : RoleExpression
    {
        public void Interpret(Context context)
        {
            if (context.Formula.Contains("S"))
            {
                context.TotalPoint += 15;
            }
        }
    }

    public class DeveloperExpression : RoleExpression
    {
        public void Interpret(Context context)
        {
            if (context.Formula.Contains("D"))
            {
                context.TotalPoint += 20;
            }
        }
    }
}
