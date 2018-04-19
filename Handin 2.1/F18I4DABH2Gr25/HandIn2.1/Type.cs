using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandIn2._1
{
    public class Type //Contains information about age and sex
    {
        [Key]
        public int TypeID { get; set; }
        private string _age;
        private string _sex;

        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
    }
}
