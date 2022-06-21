//CUSTOM EXCEPTION LAYER

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicManagementSystem.CustomExceptionLayer
{
    public class MusicManagementCustomException : Exception
    {
        public MusicManagementCustomException(string message) : base(message)
        {

        }
    }
}
