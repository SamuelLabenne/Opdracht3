using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal class Stapel<T>
    {
        List<T> lijst = new List<T>();

        public void voegToe(T obj)
        {
            lijst.Add(obj);
        }

        public T Verwijderen()
        {
            if (lijst.Count == 0)
                throw new StackOverflowException();
            T del = lijst[0];
            lijst.RemoveAt(0);
            return del;
        }

        public void Leegmaken(T allesWissen)
        {
            lijst.Clear();
        }

        public bool isAanwezig(T obj)
        {
            if (lijst.Contains(obj))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Stapel<T> Copy()
        {
            return (Stapel<T>)MemberwiseClone();
        }

        public override string ToString()
        {
            return String.Join(" + ", lijst);
        }
    }
}
