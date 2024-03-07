using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationtrigger : MonoBehaviour
{
     Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            
            m_Animator.ResetTrigger("pushup");

            m_Animator.ResetTrigger("run-jump");

            m_Animator.ResetTrigger("pray");

            m_Animator.ResetTrigger("run");
            
            m_Animator.SetTrigger("jump");
        }

        if (Input.GetKey(KeyCode.R))
        {
            
            m_Animator.ResetTrigger("jump");

            m_Animator.ResetTrigger("run-jump");

            m_Animator.ResetTrigger("pray");

            m_Animator.ResetTrigger("run");
            
            m_Animator.SetTrigger("pushup");
        }
        if (Input.GetKey(KeyCode.E))
        {
            
            m_Animator.ResetTrigger("jump");

            m_Animator.ResetTrigger("run-jump");

            m_Animator.ResetTrigger("pushup");

            m_Animator.ResetTrigger("run");
            
            m_Animator.SetTrigger("pray");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            
            m_Animator.ResetTrigger("jump");

            m_Animator.ResetTrigger("pushup");

            m_Animator.ResetTrigger("pray");
            
            m_Animator.SetTrigger("run-jump");
        }


       

        
    }
}
