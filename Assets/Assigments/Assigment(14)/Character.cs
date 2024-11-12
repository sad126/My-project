using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class Character 
{
   
    private int health;
    public int Health
    
    {
        get{
            return health;
        }
        set {
            if(value < 100){
                health = value;
            }
            else {
                health = 100;
            }
        }
    }
    private string name;
    public string Name
    {
        set{
            name = value;
        }
        get{
            return name;
        }
    }
    public Character(string name, int health){
        this.name = name;
        this.health = health;
    }

}
