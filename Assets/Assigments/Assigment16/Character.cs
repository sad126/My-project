using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assigment18{
    public class Character{
        public string name;
        private int health;
        protected Position position;
        public int Health{
            get{return  health;}
            set{if(value <= 100 && value >= 0)health = value;}
        }
        public Character(string name, int Health, Position position){
            this.name = name;
            this.health = Health;
            this.position = position;
        }
        public Character():this("no Name", 100, new Position(0, 0 , 0)){

        }
        public virtual void  DisplayInfo(){
            Debug.Log("the name is  " + this.name + "  the health is " + Health  + "\n the position is  ");
            position.printPosition();
        }
        public void Attack(int damage, Character target){
            target.Health-=damage;

        }
        public void Attack(int damage, Character target, string attackType){
            target.Health-=damage;
        }
    }
}