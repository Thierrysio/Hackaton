using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Modeles
{
    public class Conference
    {
        #region Attributs

        public static List<Conference> CollClasse = new List<Conference>();

        #endregion

        #region Constructeurs

        public Conference()
        {
            Conference.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Theme { get; set; }
        [OneToMany]
        public List<Evenement> LesEvenements { get; set; }
        #endregion

        #region Methodes

        #endregion
    }
}
