using System;
using System.Collections.Generic;
using System.Linq;

namespace SportLibrary
{
    public static class Referee
    {
        /// <summary>
        /// Сортирует согласно заданному параметру
        /// </summary>
        public static IEnumerable<object> SortResult(IEnumerable<Sportsman> items)
        {
            List<Sportsman> sportsman = new List<Sportsman>();
            sportsman.AddRange(items);
            return sportsman.OrderBy(item => item.GetResult()).AsEnumerable();

            
        }
        public static IEnumerable<int> GetStartPosition( int min, int max )
        {
            Random rnd = new Random();
            int count = max - min;
            List<int> position = new List<int>();
            while (position.Count != count)
            {
                int value = rnd.Next(min, max);
                bool result = position.Contains(value);
                if (!result)
                    position.Add(value);
            }
            return position;
        }
    }
}
