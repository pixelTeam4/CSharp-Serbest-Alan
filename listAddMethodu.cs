class MyList<T>
    {
        T[] _arrays;
        T[] _tempArray;
        public MyList()
        {
            _arrays = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _arrays;
            _arrays = new T[_arrays.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _arrays[i] = _tempArray[i];
            }
            _arrays[_arrays.Length - 1] = item;
        }
        public int Count
        {
            get { return _arrays.Length; }
        }
