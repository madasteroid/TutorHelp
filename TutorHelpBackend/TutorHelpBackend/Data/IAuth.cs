using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutorHelpBackend.Data
{
    public interface IAuth
    {
        void Login();
        void SignUp();
    }
}
