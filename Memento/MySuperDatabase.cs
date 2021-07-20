using System;

namespace Memento
{
    public class MySuperDatabase
    {
        private int _entriesCount = 5;
        private int _actionsCount = 0;

        public void RemoveEntry()
        {
            if (_entriesCount > 0)
            {
                _entriesCount--;
                _actionsCount++;
                
                Console.WriteLine($"remove entry, entry count:{_entriesCount}, actions count {_actionsCount}");
            }
            else
            {
                Console.WriteLine("Entries is Empty");
            }

        }

        public MySuperDatabaseMemento GetBackup()
        {
            Console.WriteLine("Create backup");
            return new MySuperDatabaseMemento(_entriesCount, _actionsCount);
        }

        public void RestoreDatabase(MySuperDatabaseMemento databaseMemento)
        {
            _entriesCount = databaseMemento.EntriesCount;
            _actionsCount = databaseMemento.ActionsCount;
            Console.WriteLine("Database restored");
        }
    }
}