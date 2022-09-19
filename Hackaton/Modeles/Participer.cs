using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Modeles
{
    public class Participer
    {
        [ForeignKey(typeof(Membre))]
        public int MembreId { get; set; }
        [ForeignKey(typeof(Initiation))]
        public int InitiationID { get; set; }
    }
}
