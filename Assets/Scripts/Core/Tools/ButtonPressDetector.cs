using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonPressDetector : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private PlayerController m_PlayerController;

    private void Awake()
    {
        m_PlayerController = Utility.DoesGameObjectWithScriptExistAndReturn<PlayerController>();
    }
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        if (m_PlayerController != null)
            m_PlayerController.IsAccelerating = true;
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        if (m_PlayerController != null)
            m_PlayerController.IsAccelerating = false;
    }
}
