using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class PhoneSale
    {
        private int idPhoneSale;
        private Phone phone;
        private Sale sale;

        public PhoneSale()
        {
            this.IdPhoneSale = -1;
            this.Phone = new Phone();
            this.Sale = new Sale();
        }

        public PhoneSale(int idPhoneSale, Phone phone, Sale sale)
        {
            this.IdPhoneSale = idPhoneSale;
            this.Phone = phone;
            this.Sale = sale;
        }

        public int IdPhoneSale
        {
            get
            {
                return idPhoneSale;
            }

            set
            {
                idPhoneSale = value;
            }
        }

        internal Phone Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        internal Sale Sale
        {
            get
            {
                return sale;
            }

            set
            {
                sale = value;
            }
        }
    }
}
