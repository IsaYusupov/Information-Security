using PixelCrew.UI.MainMenu;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Skripts
{
    public class PauseMenu : MonoBehaviour

    {
        public bool PauseGame;
        public GameObject pauseGameMenu;
        public GameObject MainMenu;
        public GameObject PauseButton;
    
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (PauseGame)
                {
                    Resume(); 
                }
                else
                {
                    Pause();
                }
            }
        }
        public void Pause()
        {
            pauseGameMenu.SetActive(true);
            Time.timeScale = 0f;
            PauseGame = true;
        }
        public void Resume()
        {
            pauseGameMenu.SetActive(false);
            Time.timeScale = 1f;
            PauseGame = false; 
        }

    

        public void LoadMenu()
        {
            PauseButton.SetActive(false);
            MainMenu.SetActive(true);
            Resume();
        }
    }
}
