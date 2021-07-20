using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class CarsCollection : MyIteratorAggregate
    {
        private readonly List<string> _collection = new List<string>();
        
        private bool _direction;
        
        public void ReverseDirection()
        {
            _direction = !_direction;
        }
        
        public List<string> GetItems()
        {
            return _collection;
        }
        
        public void AddItem(string item)
        {
            this._collection.Add(item);
        }
        
        public override IEnumerator GetEnumerator()
        {
            return new ConcreteIterator(this, _direction);
        }
    }
}