using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqKata.Domene
{
    public class Personer : IList<Person>
    {
        private List<Person> fPersonerFelt;
        private List<Person> fPersoner
        {
            get
            {
                if (fPersonerFelt == null)
                {
                    fPersonerFelt = new List<Person>();
                }

                return fPersonerFelt;
            }
        }

        public int IndexOf(Person item)
        {
            return fPersoner.IndexOf(item);
        }

        public void Insert(int index, Person item)
        {
            fPersoner.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            fPersoner.RemoveAt(index);
        }

        public Person this[int index]
        {
            get
            {
                return fPersoner[index];
            }
            set
            {
                fPersoner[index] = value;
            }
        }

        public void Add(Person item)
        {
            fPersoner.Add(item);
        }

        public void Clear()
        {
            fPersoner.Clear();
        }

        public bool Contains(Person item)
        {
            return fPersoner.Contains(item);
        }

        public void CopyTo(Person[] array, int arrayIndex)
        {
            fPersoner.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return fPersoner.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(Person item)
        {
            return fPersoner.Remove(item);
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return fPersoner.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
