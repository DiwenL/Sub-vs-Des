using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RoundControl : MonoBehaviour
{
    public int roundCount;
    public int stepCount;
    public GameObject subPlayer1;
    public GameObject subPlayer2;
    public GameObject desPlayer1;
    public GameObject desPlayer2;

    private bool sub1ready = false;
    private bool sub2ready = false;
    private bool des1ready = false;
    private bool des2ready = false;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetAction(GameObject player)
    {
        
    }

    void BeginAct()
     {

     }


    // Update is called once per frame
    void Update()
    {
        if (sub1ready & sub2ready & des1ready & des2ready){
            BeginAct();
            roundCount ++;
            sub1ready = false;
            sub2ready = false;
            des1ready = false;
            des2ready = false;
        }

    }
}
