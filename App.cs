namespace ThomasB
{
    internal class App
    {
        private readonly Person[] _people;

        public App(Person[] people)
        {
            _people = people;
        }

        public List<Person> GetChildren(Person person)
        {
            var children = new List<Person>();
            foreach (var p in _people)
            {
                if (p.Father == person || p.Mother == person)
                {
                    children.Add(p);
                }
               


            }
            return children;
        }
    }
}
