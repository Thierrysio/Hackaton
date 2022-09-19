using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Modeles
{
    public class Prevoir
    {
        [ForeignKey(typeof(Materiel))]
        public int MaterielId { get; set; }
        [ForeignKey(typeof(Initiation))]
        public int InitiationID { get; set; }
        public int Quantite { get; set; }    
    }
}
