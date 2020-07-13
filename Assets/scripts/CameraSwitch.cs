using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject CurrentCam;
    public GameObject NewCam;


    void Start()
    {
        
    }

    
    
    public void OnClick()
    {
        CurrentCam.SetActive(false);
        NewCam.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
