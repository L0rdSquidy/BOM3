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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            
            m_Animator.ResetTrigger("pushup");

            m_Animator.ResetTrigger("pray");
            
            m_Animator.SetTrigger("jump");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            
            m_Animator.ResetTrigger("jump");

            m_Animator.ResetTrigger("pray");
            
            m_Animator.SetTrigger("pushup");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            m_Animator.ResetTrigger("jump");

            m_Animator.ResetTrigger("pushup");
            
            m_Animator.SetTrigger("pray");
        }
    }
}
