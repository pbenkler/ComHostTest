using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;

namespace ComHostTest
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("4c493081-116d-434d-852f-b3ff26b0d5ce")]
    public interface IInt32Collection
    {
        int Count { get; }

        Array Items { get; }

        int this[int index] { get; set; }

        void Add(int item);

        void Clear();

        bool Contains(int item);

        int IndexOf(int item);

        void Insert(int index, int item);
        bool Remove(int item);

        void RemoveAt(int index);
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("e7fed84e-5f09-4fc7-96e3-4bc7705b1dc3")]
    public class Int32Collection : IInt32Collection, IEnumerable<int>
    {
        private Collection<int> items;

        public Int32Collection()
            : base()
        {
            this.items = new Collection<int>();
        }

        public int Count
        {
            get { return this.items.Count; }
        }

        public Array Items
        {
            get
            {
                int[] items = new int[this.items.Count];
                this.items.CopyTo(items, 0);

                return items;
            }
        }

        public int this[int index]
        {
            get { return this.items[index]; }
            set { this.items[index] = value; }
        }

        public void Add(int item)
        {
            this.items.Add(item);
        }

        public void Clear()
        {
            this.items.Clear();
        }

        public bool Contains(int item)
        {
            return this.items.Contains(item);
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return this.items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.items.GetEnumerator();
        }

        public int IndexOf(int item)
        {
            return this.items.IndexOf(item);
        }

        public void Insert(int index, int item)
        {
            this.items.Insert(index, item);
        }

        public bool Remove(int item)
        {
            return this.items.Remove(item);
        }

        public void RemoveAt(int index)
        {
            this.items.RemoveAt(index);
        }
    }
}
