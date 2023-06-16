using UnityEngine;

public class lampOffAnim : MonoBehaviour
{
   private static readonly int On = Animator.StringToHash("On");
   private static readonly int Off = Animator.StringToHash("Off");
   private Animator _animator;
   public GameObject LightButtonOn;
   public GameObject LightButtonOff;
   private void Start()
   {
      _animator = GetComponent<Animator>();
   } 
   public void lightOn()
   { 
      _animator.SetTrigger(On);
      LightButtonOn.SetActive(false);
      LightButtonOff.SetActive(true);
   } 
   public void lightoff()
   {
      _animator.SetTrigger(Off);
      LightButtonOn.SetActive(true);
      LightButtonOff.SetActive(false);
   }
}
