using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleFlyweightPattern.Trees
{
    public class TreeFactory
    {
        static Dictionary<string, TreeType> treeTypes = new Dictionary<string, TreeType>();

        public static TreeType GetTreeType(string name, Color color, string otherTreeData)
        {
            TreeType result = treeTypes.GetValueOrDefault(name);
            
            if (result == null) 
            {
                result = new TreeType(name, color, otherTreeData);
                treeTypes.Add(name, result);
            }
            
            return result;
        }
    }
}
