
using UnityEngine;

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

