using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekOpdrachtDependencyInjection.Business.Models;

namespace WeekOpdrachtDependencyInjection.Business
{
    public class Chicken : Bird
    {
        public override string Sound()
        {
            return "cluck";
        }
    }
}
