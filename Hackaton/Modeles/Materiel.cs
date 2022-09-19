
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Modeles
{
    public class Materiel
    {
        #region Attributs

        public static List<Materiel> CollClasse = new List<Materiel>();

        #endregion

        #region Constructeurs

        public Materiel()
        {
            Materiel.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Libelle { get; set; }
        [ManyToMany(typeof(Prevoir))]
        public List<Initiation> LesInitiations { get; set; }
        #endregion

        #region Methodes

        #endregion
    }
}
