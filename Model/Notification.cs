using Kotlin.Jvm.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalNotesNew.Model
{
    internal class Notification
    {
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public DateTime Scheduled { get; set; }
       

    }
}
