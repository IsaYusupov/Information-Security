using UnityEngine;

namespace Skripts
{
    public class Library : MonoBehaviour

    {
        public GameObject library;
        public void OnShowLibraryButton()
        {
            library.SetActive(true);
        }
        public void OnCloseLibraryButton()
        {
            library.SetActive(false);
        }
    }
}