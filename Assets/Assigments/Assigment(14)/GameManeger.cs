 using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using UnityEngine;

public class GameManeger :  MonoBehaviour
{
    void Start(){
        Player player = new Player("hany", 60);
        Enemy en = new Enemy("rrr", 80);
        
        Debug.Log("the enemy name is " + en.Name + " th health is " +en.Health);
        Debug.Log("the player name is " + player.Name + " th health is " + player.Health);
        player.Heal(10);
        Debug.Log("the player name is " + player.Name + " th health is " + player.Health);

        en.Attack(player, 10);
        
        Debug.Log("the player name is " + player.Name + " th health is " + player.Health);

    }

}