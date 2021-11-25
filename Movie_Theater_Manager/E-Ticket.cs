using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Theater_Manager
{
    public class E_Ticket
    {
        public int ID { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int ShowtimeID { get; set; }
        public int UserAccountID { get; set; }

        public E_Ticket()
        {
            ID = 0;
            PurchaseDate = new DateTime();
            ShowtimeID = 0;
            UserAccountID = 0;
        }

        public E_Ticket(int id, DateTime purchaseDate, int showtimeID, int userAccountID)
        {
            ID = id;
            PurchaseDate = purchaseDate;
            ShowtimeID = showtimeID;
            UserAccountID = userAccountID;
        }
    }
}
