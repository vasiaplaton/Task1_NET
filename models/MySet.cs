using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.models
{
    public class Set<T>
    {
        private List<T> items;

        public Set()
        {
            items = new List<T>();
        }

        public int Count => items.Count;
        public bool IsEmpty => Count == 0;

        public void Add(T item)
        {
            if (!Contains(item))
            {
                items.Add(item);
            }
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public bool Contains(T item)
        {
            foreach (var i in items)
            {
                if (EqualityComparer<T>.Default.Equals(i, item))
                {
                    return true;
                }
            }
            return false;
        }

        public void Clear()
        {
            items.Clear();
        }

        public T[] ToArray()
        {
            return items.ToArray();
        }

        public override string ToString()
        {
            return "{" + string.Join(", ", items) + "}";
        }
    }

}
