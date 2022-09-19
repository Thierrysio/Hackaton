using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Modeles
{
    public class Membre
    {
        #region Attributs

        public static List<Membre> CollClasse = new List<Membre>();

        #endregion

        #region Constructeurs

        public Membre()
        {
            Membre.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mel { get; set; }
        public string Telephone { get; set; }
        [OneToMany]
        public List<Evenement> LesEvenements { get; set; }
        [ManyToMany(typeof(Participer))]
        public List<Initiation> LesInitiations{ get; set; }
        

        #endregion

        #region Methodes

        #endregion
    }
}
