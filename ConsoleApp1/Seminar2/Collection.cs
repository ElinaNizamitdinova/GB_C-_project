﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_tasks.Seminar2
{
    public class Collection<T> : IIndexable<T>
    {
        private T[] _arr;

        public T this[int index] 
        { get => _arr[index];
            set => _arr[index] = value;
        }
        public Collection(int size)
        {
            _arr = new T[size];

        }
    }
}
