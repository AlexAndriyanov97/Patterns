using System.Collections;

namespace Iterator
{
    public abstract class MyIterator : IEnumerator
    {
        public abstract object Current();
        
        public abstract bool MoveNext();
        
        public abstract void Reset();

        object IEnumerator.Current => Current();
    }
}