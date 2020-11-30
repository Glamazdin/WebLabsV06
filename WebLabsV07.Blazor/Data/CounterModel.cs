using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebLabsV07.Blazor.Data
{
    public class CounterModel
    {
        [DataType("int")]
        [Range(0,int.MaxValue)]
        public int CounterValue { get; set; }
        
    }
}
