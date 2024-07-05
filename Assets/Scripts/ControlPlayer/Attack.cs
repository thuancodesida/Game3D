using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private Animator animator;
    private string horizontalInput = "Horizontal";
    private string verticalInput = "Vertical";

    private void Start()
    {
        // Lấy Animator từ đối tượng
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Kiểm tra nút nhấn để tấn công
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(Input.GetAxis(horizontalInput)!=0 || Input.GetAxis(verticalInput)!=0)
            {
                animator.SetTrigger("AttackMask");
            }
            else
            {
                animator.SetTrigger("Attack");
            }
        }
        //if ((Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.UpArrow)) || (Input.GetKeyDown(KeyCode.RightShift) && Input.GetKeyDown(KeyCode.UpArrow)))
         //   animator.SetBool("FastRun", true);
 
    }
}
