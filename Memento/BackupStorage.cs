using System.Collections.Generic;

namespace Memento
{
    public class BackupStorage
    {
        private readonly Stack<MySuperDatabaseMemento> _backupsList;

        public BackupStorage()
        {
            _backupsList = new Stack<MySuperDatabaseMemento>();
        }

        public void AddBackup(MySuperDatabaseMemento backup)
        {
            _backupsList.Push(backup);
        }

        public MySuperDatabaseMemento GetLastBackup()
        {
            return _backupsList.Pop();
        }
    }
}