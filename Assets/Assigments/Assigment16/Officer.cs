using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assigment18{
    public class Officer : Character
    {
        public Officer(string name, int Health, Position position) : base(name, Health, position)
        {

        }
        public Officer() : base(){}
        public override void  DisplayInfo(){

            Debug.Log("Officer");
            base.DisplayInfo();
        }
       

    }
}