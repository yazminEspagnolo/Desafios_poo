using System;

namespace Ucu.Poo.Defense
{
    public class PublicationDiscount : IPublicationItem
    {
        private int amount;

        public int SubTotal
        {
            get
            {
                return this.amount;
            }
            set
            {
                if (value >= 0)
                {
                    throw new ArgumentException("Introduzca un valor negativo para el descuento"); // Agregamos una excepción para indicar que el descuento sea negativo.
                }
                this.amount = value;
            }
        }

        public PublicationDiscount(int amount)
        {
            this.SubTotal = amount;
        }
    }
}