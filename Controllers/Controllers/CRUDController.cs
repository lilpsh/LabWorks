using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
* @author - Michael Mushynskyi
*
* @date - 10/27/2019 5:06:59 AM 
*/

namespace Controllers.Controllers
{
    public abstract class CRUDController
    {
        public bool isActive { get ; protected set; }
        protected abstract string Add(string input);
        protected abstract string Remove(string input);
        protected abstract string Change(string input);
        public abstract string CheckInput(string input, string command);
        protected abstract string Get(string input);
        protected abstract string GetAll(string input);
        public virtual string GetCommands()
        {
            return "\nGet     - get item by Id;" +
                   "\nGet All - get all items;" +
                   "\nAdd     - add item;" +
                   "\nRemove  - remove item by Id;" +
                   "\nChange  - change item;\n" +
                   "\nBack    - return to home screen.\n";
        }
    }
}
