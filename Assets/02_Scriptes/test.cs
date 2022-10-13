using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private Animator ani;
    private Live2D.Cubism.Framework.Expression.CubismExpressionController expressionController;
    void Start()
    {
        ani = GetComponent<Animator>();
        expressionController = GetComponent<Live2D.Cubism.Framework.Expression.CubismExpressionController>();
    }

    // Update is called once per frame
    void Update()
    {
        Fac();
    }


    public void motionButton(int a)
    {
        switch(a)
        {
            case 2 :
                ani.SetTrigger("02");
                break;
            case 3 :
                ani.SetTrigger("03");
                break;
            case 4 :
                ani.SetTrigger("04");
                break;
            case 5 :
                ani.SetTrigger("05");
                break;
            case 6 :
                ani.SetTrigger("06");
                break;
            case 7 :
                ani.SetTrigger("07");
                break;
            case 8 :
                ani.SetTrigger("08");
                break;
            case 9 :
                ani.SetTrigger("09");
                break;
            case 10 :
                ani.SetTrigger("10");
                break;
        }
        
    }

    private void Fac()
    {
        if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            expressionController.CurrentExpressionIndex =0;
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            expressionController.CurrentExpressionIndex =1;
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            expressionController.CurrentExpressionIndex =2;
        }

        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            expressionController.CurrentExpressionIndex =3;
        }

        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            expressionController.CurrentExpressionIndex =4;
        }

        if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            expressionController.CurrentExpressionIndex =5;
        }
    }

    private bool Animationing()
    {
        return ani.GetCurrentAnimatorStateInfo(0).IsName("string AnimationName") &&
        ani.GetCurrentAnimatorStateInfo(0).normalizedTime < 0.95f;
    }
}
