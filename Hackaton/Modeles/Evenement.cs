using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Modeles
{
    public class Evenement
    {
        #region Attributs

        public static List<Evenement> CollClasse = new List<Evenement>();

        #endregion

        #region Constructeurs

        public Evenement()
        {
            Evenement.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Libelle { get; set; }
        public DateTime DateHeure { get; set; }
        public int Duree { get; set; }
        public string Salle { get; set; }
        public string TypePublic { get; set; }

        [ForeignKey(typeof(Membre))]
        public Membre LeAnimateur { get; set; }

        [ForeignKey(typeof(Conference))]
        public Conference LaConference { get; set; }

        [OneToMany]
        public List<Initiation> LesInitiations { get; set; }

        #endregion

        #region Methodes

        #endregion
    }
}
