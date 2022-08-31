using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class MatchNotFoundException : Exception
    {
        public MatchNotFoundException(int id)
        : base($"The company with id: {id} doesn't exist in the database.")
        {
        }
    }
}
