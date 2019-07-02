using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioClinic
{
    class Client
    {    
        private IHeart _heart;

        public void InstalHeart(IHeart heart)
        {
            _heart = heart;
            heart.Connect();
        }
    }
}
