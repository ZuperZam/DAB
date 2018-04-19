using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandIn2._1
{
    public class Name //Gets and sets a name with first, middle and last name
    {
        [Key]
        public int NameID { get; set; }
        private string _name = "";
        private string _firstname = "";
        private string _middlename = "";
        private string _lastname = "";

        public string FullName
        {
            get { return _name; }
            private set { _name = value; }
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
