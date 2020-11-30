using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLabsV06.Models
{
    public class ListViewModel1<T>:List<T> where T:class
    {
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        private ListViewModel1(IEnumerable<T> items,
                                int total,
                                int current) 
            : base(items)
        {
            TotalPages = total;
            CurrentPage = current;
        }
        /// <summary>
        /// Получить модель представления списка объектов
        /// </summary>
        /// <param name="list">исходный список объектов</param>
        /// <param name="current">номер текущей страницы</param>
        /// <param name="itemsPerPage">кол. объектов на странице</param>
        /// <returns>объект класса ListViewModel</returns>
        public static ListViewModel1<T> GetModel(IEnumerable<T> list,
        int current, int itemsPerPage)
        {
            var items = list
            .Skip((current - 1) * itemsPerPage)
            .Take(itemsPerPage)
            .ToList();
            var total = (int)Math.Ceiling((double)list.Count() / itemsPerPage);
            return new ListViewModel1<T>(items, total, current);
        }
    }
}
