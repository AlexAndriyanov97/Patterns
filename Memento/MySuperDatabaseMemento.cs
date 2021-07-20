namespace Memento
{
    public class MySuperDatabaseMemento
    {
        public int EntriesCount { get; private set; }
        public int ActionsCount { get; private set; }

        public MySuperDatabaseMemento(int entriesCount, int actionsCount)
        {
            EntriesCount = entriesCount;
            ActionsCount = actionsCount;
        }
    }
}