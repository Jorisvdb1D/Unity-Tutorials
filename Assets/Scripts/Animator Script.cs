using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            m_Animator.ResetTrigger("Idle");
            m_Animator.SetTrigger("Jump");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_Animator.ResetTrigger("Jump");
            m_Animator.SetTrigger("Run");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_Animator.ResetTrigger("Run");
            m_Animator.SetTrigger("Idle");
        }
    }
}
