using System.Collections;

namespace Iterator
{
    public abstract class MyIteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}