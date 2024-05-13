using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Core.AI
{
    public class SetFoxSpeed : Action
    {
        public float FoxSpeed = 0f;
        private Animator m_FoxAnimator;
        private readonly int m_Speed = Animator.StringToHash("Speed");
        public override void OnAwake()
        {
            m_FoxAnimator = this.GetComponent<Animator>();
        }

        public override void OnStart()
        {
            m_FoxAnimator.SetFloat(m_Speed, FoxSpeed);
        }
    }
}

