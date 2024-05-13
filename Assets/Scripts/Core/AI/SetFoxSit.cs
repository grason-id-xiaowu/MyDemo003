using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Core.AI
{
    public class SetFoxSit : Action
    {
        public bool Sit;
        private Animator m_FoxAnimator;
        private readonly int m_Sit = Animator.StringToHash("Sit");
        public override void OnAwake()
        {
            m_FoxAnimator = this.GetComponent<Animator>();
        }
        public override void OnStart()
        {
            m_FoxAnimator.SetBool(m_Sit, Sit);
        }
    }
}
