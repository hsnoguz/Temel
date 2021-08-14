﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
 public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Telephone{ get; set; }
        public string Email { get; set; }
        public Int16[] SubeID { get; set; }
        public string IsActive { get; set; }
        public DateTime InsertTime { get; set; }
    }
}
