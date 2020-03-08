using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
	public class MyList<T> : IEnumerable, IEnumerator
	{
		public int Count { get; private set; } = 0;
		T[] LinkedArray;

		public MyList()
		{
			LinkedArray = new T[5];
		}

		public MyList(int Captivity)
		{
			LinkedArray = new T[Captivity];
		}

		int position = -1;

		public void Clear()
		{
			LinkedArray = new T[5];
			Count = position = 0;
			;
		}

		public bool FindElement(T item) 
		{

			foreach (T val in LinkedArray)
			{
				if (val.Equals(item))
					return true;
			}
			return false;
		}
		
		public void Add(T LinkedArray) 
		{
			Count++;
			Array.Resize(ref this.LinkedArray, Count);
			position++;
			this.LinkedArray[position] = LinkedArray; 

		}
		public  void RemoveAt(int index)
		{
			for (int i = index;i < Count - 1;i++)
			{
				LinkedArray[i] = LinkedArray[i + 1];
			}
			--Count;
			Array.Resize(ref this.LinkedArray, Count);
			
		}
		public bool MoveNext() 
		{
			position++;
			return (position < LinkedArray.Length);
		}

		public void Reset()
		{
			position = 0;
		}
		public T Current
		{
			get { try { return LinkedArray[position]; } catch (IndexOutOfRangeException) { throw new InvalidOperationException(); } }
		}


		object IEnumerator.Current
		{
			get { return Current; }
		}


		public IEnumerator GetEnumerator()
		{
			return LinkedArray.GetEnumerator();
		}

		public T this[int index]
		{
			get { return LinkedArray[index]; }
			set { LinkedArray[index] = value; }
		}


	}
}
