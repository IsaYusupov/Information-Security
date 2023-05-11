using PixelCrew.Components.Audio;
using PixelCrew.Model.Data;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour

{
    private Hero _hero;


    private void Awake()
    {
        _hero = GetComponent<Hero>();
    }
   
   
    private void Update()
    {
      var horizontal = Input.GetAxis("Horizontal");
      _hero.SetDirectionX(horizontal);
      var vertical = Input.GetAxis("Vertical"); 
      _hero.SetDirectionY(vertical);
    }
    
    
}

