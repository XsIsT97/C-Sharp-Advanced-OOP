using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy.Classes
{
    public class AddAndRemoveCollection : AddCollection, IAddAndRemove
    {
        public AddAndRemoveCollection()
        {
        }

        public override int Add(string item)
        {
            List.Insert(0, item);
            return 0;
        }
        public virtual string Remove()
        {
            string lastItem = List[List.Count - 1];
            List.RemoveAt(List.Count - 1);
            return lastItem;
        }
    }
}
