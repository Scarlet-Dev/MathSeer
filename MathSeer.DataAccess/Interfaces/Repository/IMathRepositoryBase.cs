using System;
using System.Collections.Generic;
using System.Text;

namespace MathSeer.DataAccess.Interfaces
{
    public interface IMathRepositoryBase : IRepositoryBase
    {
        public string[] ParseExpression();

        public void Calculate();
    }
}
