using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Modeles
{
    [Table("Hackathon")]
    public class Hackathon
    {
        #region Attributs

        public static List<Hackathon> CollClasse = new List<Hackathon>();

        #endregion

        #region Constructeurs

        public Hackathon()
        {
            Hackathon.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }  
        public DateTime DateHeureDebut { get; set; }
        public DateTime DateHeureFin { get; set; }
        public string Lieu { get; set; }
        public string Ville { get; set; }
        public string Theme { get; set; }
        public string Affiche { get; set; }
        public string Objectifs { get; set; }

        [OneToMany]
        List<Evenement> LesEvenements { get; set; }
        #endregion

        #region Methodes

        #endregion
    }
}
