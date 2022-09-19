using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Modeles
{
    public class Initiation
    {
        #region Attributs

        public static List<Initiation> CollClasse = new List<Initiation>();

        #endregion

        #region Constructeurs

        public Initiation()
        {
            Initiation.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int NbPlaces { get; set; }
        [ForeignKey(typeof(Evenement))]
        public Evenement LeEvenemnt { get; set; }

        #endregion

        #region Methodes

        #endregion
    }
}
