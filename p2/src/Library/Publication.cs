using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Publication
    {
        public DateTime EndDate { get; set; }

        public IReadOnlyCollection<PublicationItem> Items
        {
            get
            {
                return new ReadOnlyCollection<PublicationItem>(this.items);
            }
        }

        private IList<PublicationItem> items = new List<PublicationItem>();

        public Publication(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public void AddItem(PublicationItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(PublicationItem item)
        {
            this.items.Remove(item);
        }

        public string AsText() 
        {
            StringBuilder sb = new StringBuilder(); // Creo un StringBuilder para armar el texto.
            sb.AppendLine("Publicación");
            sb.AppendLine("Fecha de cierre: " + this.EndDate.ToString("dd/MM/yyyy"));
            sb.AppendLine("Items:");
            foreach (PublicationItem item in this.items) // Recorro la lista de items.
            {
                sb.AppendLine(item.Material.Name + " - " + item.Quantity + " - " + item.Price); // Agrego cada item al texto.

            }
            return sb.ToString(); // Devuelvo el texto.
        }
    }
}