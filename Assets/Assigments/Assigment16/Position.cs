using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assigment18{
    public struct Position 
    {
       public float x;
       public float y;
       public float z;

       public Position(float x, float y, float z){
        this.x = x;
        this.y = y;
        this.z = z;

       }
       public void printPosition(){
        Debug.Log("the x = " + this.x + " ,the y = " + this.y + " and the z = " + this.z);
       }

    }
}
