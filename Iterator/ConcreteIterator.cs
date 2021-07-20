namespace Iterator
{
    public class ConcreteIterator : MyIterator
    {
        private readonly CarsCollection _collection;
        private int _position = -1;
        private readonly bool _revers;

        public ConcreteIterator(CarsCollection collection, bool revers)
        {
            _collection = collection;
            _revers = revers;

            if (revers)
            {
                _position = collection.GetItems().Count;
            }
        }

        public override object Current()
        {
            return _collection.GetItems()[_position];
        }

        public override bool MoveNext()
        {
            var updatedPosition = _position + (_revers ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < _collection.GetItems().Count)
            {
                _position = updatedPosition;
                return true;
            }

            return false;
        }

        public override void Reset()
        {
            _position = _revers ? _collection.GetItems().Count - 1 : 0;
        }
    }
}