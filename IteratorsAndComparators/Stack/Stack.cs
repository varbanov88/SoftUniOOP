using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private const int initialCount = 10;
        private T[] elemets;

        public Stack()
        {
            this.elemets = new T[initialCount];
        }

        public int Count { get; private set; }

        public void Push(T item)
        {
            if (this.Count == this.elemets.Length)
            {
                Resize();
            }

            this.elemets[this.Count] = item;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            var tempElement = this.elemets[this.Count - 1];
            this.Count--;
            return tempElement;
        }

        private void Resize()
        {
            Array.Resize(ref this.elemets, this.Count * 2);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return this.elemets[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
