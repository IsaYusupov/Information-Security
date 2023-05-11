using UnityEngine;

namespace Skripts
{
    public class BookMenu : MonoBehaviour
        
    {
        public bool PauseGame;
        public GameObject Page1;
        public GameObject BookButton;
        
            

        
        public void Resume()
        { 
          
            Page1.SetActive(false);
            Time.timeScale = 1f; 
            PauseGame = false; 
               
                
        }

        public void Pause()
        {
            Page1.SetActive(true);
            Time.timeScale = 0f;
            PauseGame = true;
                
        }
    }
}

    
