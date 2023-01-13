using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TpLivre
{
    internal class Book
    {
        #region Attribute
        private string _title;
        private string _autor;
        private double _price;
        #endregion
        #region Constructor
        /// <summary>
        /// Full Constructor 
        /// </summary>
        /// <param name="title">Titre</param>
        /// <param name="autor">Auteur</param>
        /// <param name="price">Prix</param>
        public Book(string title, string autor, double price)
        {
            _title = title;
            _autor = autor;
            _price = price;
        }
        #endregion
        #region Get & Set Title
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get => _title; set => _title = value; }
        #endregion
        #region Get & Set Autor
        /// <summary>
        /// Autor
        /// </summary>
        public string Autor { get => _autor; set => _autor = value; }
        #endregion
        #region Get & Set Price
        /// <summary>
        /// Price
        /// </summary>
        public double Price { get => _price; set => _price = value; }
        #endregion
        #region Method
        /// <summary>
        /// Method to display book
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Titre : {Title}");
            Console.WriteLine($"Auteur : {Autor}");
            Console.WriteLine($"Prix : {Price} euros");
            Console.WriteLine();
        } 
        #endregion
    }
}
