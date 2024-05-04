﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckWeigherFood.Models
{
  public class DataExcelImport
  {
    public int Stt { get; set; }
    public string SKU { get; set; }
    public string FGs { get; set; }
    public string Description { get; set; }
    public double Target { get; set; }
    public double ValueT { get; set; }
    public double LowerControl { get; set; }
    public double UpperControl { get; set; }
    public double Min { get; set; }
    public double Max { get; set; }
    public double NormalSpeed { get; set; }
  }
}
