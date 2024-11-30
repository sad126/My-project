using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assigment18
{
    public class CharacterTest : MonoBehaviour
    {
        void Start()
        {
            Character[] characters = {
                new Soldier() ,
                new Officer("ahmed", 100, new Position(5f, 3.3f, 4f))
            };
            foreach (Character item in characters)
            {
                item.DisplayInfo();
            }


            Officer ch1 = new Officer("saleem", 100, new Position(5f, 3.3f, 4f));
            Soldier ch2 = new Soldier("khaled", 100, new Position(5, 3.3f, 4));
            ch1.Attack(50, ch2);
            ch2.DisplayInfo();
        }
    }
}