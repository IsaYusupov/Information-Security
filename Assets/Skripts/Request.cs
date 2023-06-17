using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Request : MonoBehaviour
{

    [SerializeField] private GameObject Request1;
    [SerializeField] private GameObject Request2;
    [SerializeField] private GameObject Request3;
    [SerializeField] private GameObject Request4;
    [SerializeField] private GameObject Request5;
    
    public void NextPanel2()
    {
       Request1.SetActive(false);
       Request2.SetActive(true);
    }
    
    public void NextPanel3()
    {
        Request2.SetActive(false);
        Request3.SetActive(true);
    }
    
    public void NextPanel4() 
    {
        Request3.SetActive(false); 
        Request4.SetActive(true);
            
    }
    
    public void NextPanel5() 
    { 
        Request4.SetActive(false); 
        Request5.SetActive(true); 
    }

    public void End()
    {
        Request5.SetActive(false);
    }

}
