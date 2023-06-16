using UnityEngine;

public class PC : MonoBehaviour
{
    public GameObject PCButton;
    public GameObject exitButton;
    public GameObject MainWindow;
    public GameObject ReguestsMenu;
    public GameObject PauseMenu;
    public GameObject BookMenu;
    public GameObject Reguests;
    public GameObject InfoButton;
    public GameObject Hud;
    void Update()

    {
        if (Input.GetKey(KeyCode.Backspace))
        {
            Exit(); 
        }
    }

      public void OpenPc()
      {
          Reguests.SetActive(true);
          InfoButton.SetActive(true);
          MainWindow.SetActive(true);
          exitButton.SetActive(true);
          Hud.SetActive(true);
          
      }

    public void Exit()
    {
        Reguests.SetActive(false);
        InfoButton.SetActive(false);
        exitButton.SetActive(false);
        PauseMenu.SetActive(true);
        BookMenu.SetActive(true);
        MainWindow.SetActive(false);
        ReguestsMenu.SetActive(false);
        Hud.SetActive(false);
    }

    public void OpenReguests()
    {
        ReguestsMenu.SetActive(true);
        MainWindow.SetActive(false);
        Reguests.SetActive(false);
    }
}


