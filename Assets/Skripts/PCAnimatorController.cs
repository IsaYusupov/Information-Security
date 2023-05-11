using UnityEngine;


namespace Skripts
{
    public class PCAnimatorController : MonoBehaviour

    {
        private static readonly int On = Animator.StringToHash("On");
        private static readonly int Off = Animator.StringToHash("Off");
        private Animator _animator;
        
        
        public void StartAnimation()
        {
            _animator = GetComponent<Animator>();
            _animator.SetTrigger(On);
        }

        public void CloseAnimation()
        {
            _animator = GetComponent<Animator>();
            _animator.SetTrigger(Off);
        }

    }
}