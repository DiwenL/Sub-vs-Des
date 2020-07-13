using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class step : MonoBehaviour
{
    public string action = "";
    public Vector3 location;
    
    //float and dive will only got one input
    //public void step(string act){
    //    action = act;
    //}

    //move and attack will take two input
    //public void step(string act,Vector3 locate){
    //    action = act;
    //    location = locate;
    //}

    public string GetStep(){
        return action;
    }

    public Vector3 GetLocation(){
        return location;
    }

    public void ClearStep(){
        action = "";
        location = new Vector3();
    }
}