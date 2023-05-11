using UnityEngine;

public class AnimPage : MonoBehaviour
{
    
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        PlayAnim();
    }

    public void PlayAnim()
    {
        anim.SetTrigger("NextPage");
    }

}
