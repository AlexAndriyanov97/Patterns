namespace Singleton
{
    public class MySuperSingleClass
    {
        private static MySuperSingleClass _instance;
        private static readonly object lockObj = new object();
        public string Name { get; private set; }

        private MySuperSingleClass(string name)
        {
            Name = name;
        }
        
        public static MySuperSingleClass GetInstance(string name)
        {
            if (_instance == null)
            {
                lock (lockObj)
                {
                    if (_instance == null)
                        _instance = new MySuperSingleClass(name);
                }
            }
            return _instance;
        }
    }
}