using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Festival
    {
        private int id;
        private string nom;
        private string description;
       // private DateTime startDate;
        //private DateTime endDate;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Description { get => description; set => description = value; }
        //public DateTime EndDate { get => endDate; set => endDate = value; }
      //  public DateTime StartDate { get => startDate; set => startDate = value; }
    }
}
