using System;
using System.Collections.Generic;

namespace PagnationHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            TestingClass();
        }

        private static void TestingClass()
        {
            var helper = new PagnationHelper<char>(new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' }, 4);
            var a = helper.PageCount; //should == 2
            a = helper.ItemCount; //should == 6
            a = helper.PageItemCount(0); //should == 4
            a = helper.PageItemCount(1); // last page - should == 2
            a = helper.PageItemCount(2); // should == -1 since the page is invalid

            // pageIndex takes an item index and returns the page that it belongs on
            a = helper.PageIndex(5); //should == 1 (zero based index)
            a = helper.PageIndex(2); //should == 0
            a = helper.PageIndex(20); //should == -1
            a = helper.PageIndex(-10); //should == -1
        }
    }
    public class PagnationHelper<T>
    {
        private readonly IList<T> collection;
        private readonly int itemsPerPage;
        private readonly List<SortedDictionary<int, T>> pagesList = new List<SortedDictionary<int, T>>();
        // TODO: Complete this class

        /// <summary>
        /// Constructor, takes in a list of items and the number of items that fit within a single page
        /// </summary>
        /// <param name="collection">A list of items</param>
        /// <param name="itemsPerPage">The number of items that fit within a single page</param>
        public PagnationHelper(IList<T> collection, int itemsPerPage)
        {
            this.collection = collection;
            this.itemsPerPage = itemsPerPage;

            var tmpStack = new Queue<T>(collection);

            for (int i = 0; i < tmpStack.Count; i++)
            {
                pagesList.Add(new SortedDictionary<int, T>());
                for (int j = 0; j < itemsPerPage && tmpStack.Count != 0; j++)
                {
                    pagesList[i].Add(j, tmpStack.Dequeue());
                }
            }
        }

        /// <summary>
        /// The number of items within the collection
        /// </summary>
        public int ItemCount
        {
            get
            {
                return collection.Count;
            }
        }

        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount
        {
            get
            {
                return pagesList.Count;
            }
        }

        /// <summary>
        /// Returns the number of items in the page at the given page index 
        /// </summary>
        /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        public int PageItemCount(int pageIndex)
        {
            if (pageIndex >= 0 && pageIndex < pagesList.Count)
                return pagesList[pageIndex].Count;
            return -1;
        }

        /// <summary>
        /// Returns the page index of the page containing the item at the given item index.
        /// </summary>
        /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        public int PageIndex(int itemIndex)
        {
            if (itemIndex >= 0 && itemIndex < collection.Count)
                for (int i = 0; i < pagesList.Count; i++)
                    if (pagesList[i].ContainsValue(collection[itemIndex]))
                        return i;
            return -1;
        }
    }
}
