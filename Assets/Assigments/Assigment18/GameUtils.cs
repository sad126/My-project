using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assigment18
{
    public class GameUtils
    {
        public static void DescribeItem<T>(T something)
        {
            Debug.Log("this item is " + something);
        }
        
    }
}