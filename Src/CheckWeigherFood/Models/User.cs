﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckWeigherFood.Models
{
  public class User:BaseModel
  {
    public string Name { get; set; }
    public string Role { get; set; }
    public bool isEnable { get; set; }
  }
}