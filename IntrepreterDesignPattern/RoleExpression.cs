using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrepreterDesignPattern
{
    public interface RoleExpression
    {
        void Interpret(Context context);
    }
}
