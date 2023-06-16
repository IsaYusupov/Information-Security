
using UnityEngine;

public class PCButton : MonoBehaviour
{
    public GameObject pcButton;
    
    
    public void OnClosePCButton()
    {
        pcButton.SetActive(false);
    }

    public void OnShowPCButton()
    {
        pcButton.SetActive(true);
    }
    
    
}
