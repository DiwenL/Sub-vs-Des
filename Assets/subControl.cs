using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subControl : MonoBehaviour
{
    public int HP = 1000;
    public int O2 = 200;
    public int attackrange = 400;
    public int visionrange = 500; 

    //divnig level: 0 -> 0m ; 1 -> -10m ; 2 -> -75m ; 3 -> -150m
    private int divinglevel = 0;

    //move the ship, but how to deal with curve moving
    public void move(){

    }

    //attack the first ship of the derection set in range
    public void attack(Vector3 derection){
        
    }

    //float to upper diving level
    public void floatup(){
        if (divinglevel == 0){
            return;
        }
    }

    //dive to lower diving level
    public void diving(){
        if (divinglevel == 3){
            return;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0){
            Console.WriteLine("ship sunk");
        }
    }
}
