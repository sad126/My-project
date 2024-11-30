using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assigment18
{
    public class GenericsTest : MonoBehaviour
    {
        void Start(){
            GameContainer<string> gameContainer = new GameContainer<string>();
            gameContainer.SetItem("Healing Potion");
            Debug.Log(gameContainer.GetItem() + "\n");
           GameUtils.DescribeItem<string>(gameContainer.GetItem());

        }
    }
}
