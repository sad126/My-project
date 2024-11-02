using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
// Start is called before the first frame update
void Start()
{
    string temp = "";
    for(int i = 1; i <= 10; i++){
        temp += 5 + " * "  + i + " = " +(Multiply(5, i)) +" , ";
    }
    Debug.Log(temp);
}
int Multiply(int a, int b){
    return a * b;
}

// Update is called once per frame

}
