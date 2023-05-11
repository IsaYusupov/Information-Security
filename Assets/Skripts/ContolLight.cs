using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContolLight : MonoBehaviour
{
    private Light _light;

    private void Start()
    {
        _light = GetComponent<Light>();
    }

    public void OnLight()
    {
        
        _light.enabled = false;
    }

    public void OffLight()
    {
        _light.enabled = true;
    }



}
