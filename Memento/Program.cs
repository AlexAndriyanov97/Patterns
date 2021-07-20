namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var backupStorage = new BackupStorage();

            var myDatabase = new MySuperDatabase();
            myDatabase.RemoveEntry();
            myDatabase.RemoveEntry();
            myDatabase.RemoveEntry();

            backupStorage.AddBackup(myDatabase.GetBackup());
            myDatabase.RemoveEntry();
            myDatabase.RemoveEntry();
            myDatabase.RemoveEntry();

            myDatabase.RestoreDatabase(backupStorage.GetLastBackup());

            myDatabase.RemoveEntry();
            myDatabase.RemoveEntry();
        }
    }
}