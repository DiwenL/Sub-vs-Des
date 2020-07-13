using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISwitch : MonoBehaviour
{
    public GameObject currentUI;
    public GameObject newUI;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void OnClick()
    {
        currentUI.SetActive(false);
        newUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
