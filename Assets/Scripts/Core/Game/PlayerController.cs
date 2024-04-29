using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] VariableJoystick m_MoveVariableJoystick;
    [SerializeField] VariableJoystick m_DirectionVariableJoystick;
    [SerializeField] CinemachineFreeLook m_CinemachineFreeLook;

    [SerializeField] float m_RotateSpeed=1f;
    [SerializeField] float m_MoveSpeed=1f;


    private float m_Speed=0f;
    private Rigidbody m_Rigidbody;
    private Animator m_Animator;

    private float m_SpeedSmooth = 0.01f;
    private float m_AccelerateSpeed = 0.5f;

    private readonly int m_HashSpeed = Animator.StringToHash("Speed");

    private bool m_IsAccelerating = false;

    public bool IsAccelerating {
        get
        {
            return m_IsAccelerating;
        }
        set
        {
            m_IsAccelerating = value;
        }
    }

    private void Awake()
    {
        m_Rigidbody = this.GetComponent<Rigidbody>();
        m_Animator = this.GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        UpdateMovement();
        UpdateRotate();
    }

    private void UpdateMovement()
    {
        m_Speed = m_MoveVariableJoystick.Vertical > m_MoveVariableJoystick.Horizontal ? m_MoveVariableJoystick.Vertical*m_AccelerateSpeed : m_MoveVariableJoystick.Horizontal * m_AccelerateSpeed;        
        Vector3 direction = (this.transform.forward * m_MoveVariableJoystick.Vertical + Vector3.right * m_MoveVariableJoystick.Horizontal)* m_SpeedSmooth;
        this.transform.position += direction;
        m_Animator.SetFloat(m_HashSpeed, m_Speed * 0.5f);
    }

    private void UpdateRotate() 
    {
        this.transform.Rotate(new Vector3(0f, m_MoveVariableJoystick.Horizontal* m_RotateSpeed, 0f));
    }
}
