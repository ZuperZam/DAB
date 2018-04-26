using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokumentDB
{
    public class Name //Gets and sets a name with first, middle and last name
    {
        public int NameID { get; set; }
        public string _name = "";
        public string _firstname = "";
        public string _middlename = "";
        public string _lastname = "";

        public string FullName
        {
            get { return _name; }
            set { _name = value; }
        }

        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; NewFullName(); }
        }

        public string MiddleName
        {
            get { return _middlename; }
            set { _middlename = value; NewFullName(); }
        }

        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; NewFullName(); }
        }

        public void NewFullName() //Used to create a new full name every time part of a name is changed
        {
            _name = _firstname + " ";
            if (_middlename != "")
                _name += _middlename + " " + _lastname;
            else
                _name += _lastname;
        }
    }
}
