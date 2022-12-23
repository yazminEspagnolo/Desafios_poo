using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Publication 
    {
        public DateTime EndDate { get; set; }

        public IReadOnlyCollection<IPublicationItem> Items
        {
            get
            {
                return new ReadOnlyCollection<IPublicationItem>(this.items);
            }
        }

        public double Total
        {
            get
            {
                double result = 0;
                foreach (IPublicationItem item in this.items)
                {
                    result = result + item.SubTotal;
                }

                return result;
            }
        }

        private IList<IPublicationItem> items = new List<IPublicationItem>();

        public Publication(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public PublicationItem AddItem(Material material, int quantity, int price)
        {
            PublicationItem item = new PublicationItem(material, quantity, price);
            this.items.Add(item);
            return item;
        }

        public void RemoveItem(IPublicationItem item)
        {
            this.items.Remove(item);
        }

        public PublicationDiscount AddDiscount(int discount) 
        {
            PublicationDiscount item = new PublicationDiscount(discount); // Crea un descuento.
            this.items.Add(item); // Agrega el descuento a la publicación.
            return item; // Retorna el descuento.
        }
    }
}