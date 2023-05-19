using PersonNP;


namespace PersonIteratorNP
{

    public interface IIterator
    {
        bool HasNext();
        People Next();
    }
    public class PersonIterator : IIterator
    {
        private List<People> _persons;
        private int _position = 0;

        public PersonIterator(List<People> persons)
        {
            _persons = persons;
        }

        public bool HasNext()
        {
            return _position < _persons.Count;
        }

        public People Next()
        {
            People person = _persons[_position];
            _position++;
            return person;
        }
    }

}