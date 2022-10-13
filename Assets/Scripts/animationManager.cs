using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationManager : MonoBehaviour
{
    private Animator animator;
    public 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //StartCoroutine(IdleAni());
    }

    // Update is called once per frame
    void Update()
    {
        //int a;

        // if(animator.GetCurrentAnimatorStateInfo(0).IsName("CurrentStateName") &&
        //     animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
        //     {
        //         a= Random.Range(1,3);
        //         switch(a)
        //         {
        //             case 1:
        //                 animator.SetTrigger("idle1");
        //                 break;
        //             case 2 :
        //                 animator.SetTrigger("idle2");
        //                 break;
        //         }
        //     }
    }

    private void AnimationController()
    {
        
    }

    // IEnumerator IdleAni()
    // {
    //     int a;
    //     while(true)
    //     {
    //         if(animator.GetCurrentAnimatorStateInfo(0).IsName("CurrentStateName") &&
    //         animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
    //         {
    //             a= Random.Range(1,3);
    //             switch(a)
    //             {
    //                 case 1:
    //                     animator.SetTrigger("idle1");
    //                     break;
    //                 case 2 :
    //                     animator.SetTrigger("idle2");
    //                     break;
    //             }
    //         }
    //     }
        
    // }

    public void AttackAnimation()
    {
        int b;
        b= Random.Range(1,5);
        switch(b)
        {
            case 1 :
                animator.SetTrigger("attack1");
                break;
            case 2 :
                animator.SetTrigger("attack2");
                break;
            case 3 :
                animator.SetTrigger("attack3");
                break;
            case 4 : 
                animator.SetTrigger("attack4");
                break;
        }
    }

    public void GameOverAnimation()
    {
        animator.SetTrigger("GameOver");
    }
}
