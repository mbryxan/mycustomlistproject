using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListYtterbium
{
    public class CustomList<T>
    {
        // member variables (fields)
        private T[] customListArray;
        private int count;
        private int capacity;

        //Count Property- readonly
        public int Count
        {
            get
            {
                return count;
            }

        }
        //capacity property- want to publicly see the size of my private array
        public int Capacity
        {

            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        //Constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            customListArray = new T[capacity];
        }

        //indexer-- create an indexer so objects in my list are accessible via index
        public T this[int index]
        {
            get
            {
                if (index < 0 && index >= count)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                else
                {
                    return customListArray[index];
                }
            }

            set
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException("Index out of range");
            }

        }

        // write an Add method

        public void Add(T value)
        {
            if (count == capacity)
            {
                capacity = capacity * 2; //double the capacity
                T[] biggerArray = new T[capacity];
                //get existing items from customListArray and put them in biggerarray (loop?)
                // for loop
                // make it run for the amount of items that are in customListArray
                // swap values over to biggerArray one by one
                // (hint use i as the index number)

                for (int i = 0; i < count; i++)
                {
                    biggerArray[i] = customListArray[i];
                }
                customListArray = biggerArray;
            }

            //how do I get biggerarray's contents to persist after this scope?
            customListArray[count] = value;
            count++;

        }

        // write a Remove Method

        public void Remove(T value)

        //remove item from list
        //reduce count of items in list
        //new count should reflect the current items in the array
        //items in array should reflect their correct positions

        {   //new list becomes smallerArray
            T[] smallerArray =

            for (int i = 0; i < count; i--)
            {
                smallerArray[i] = customListArray[i];
            }
            customListArray = smallerArray;

            //example: move index [1] to index [0]



            if (customListArray[i].count < customListArray)
            {
                customListArray.RemoveAt[0];

            }












        }






    }

}
