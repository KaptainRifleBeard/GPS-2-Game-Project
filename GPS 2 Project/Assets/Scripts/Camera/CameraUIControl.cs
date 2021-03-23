using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Test
{
    public class CameraUIControl : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
    {
        [SerializeField] Transform m_target;
        [SerializeField] CameraTool.thirdPersonCamera m_thridCamera;

        const float DRAG_TO_ANGLE = 0.5f;
        Vector2 m_previousPressPosition;
        float m_angleX, m_angleY;


        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

      

        public void OnBeginDrag(PointerEventData eventData)
        {
            m_previousPressPosition = eventData.position;
            m_thridCamera.StartRotate();
        }

        public void OnDrag(PointerEventData eventData)
        {
            m_angleX = (eventData.position.x - m_previousPressPosition.x) * DRAG_TO_ANGLE;
            m_angleY = (eventData.position.y - m_previousPressPosition.y) * DRAG_TO_ANGLE;
            m_thridCamera.Rotate(-m_angleX, -m_angleY);
            //m_target.Rotate(new Vector3(0, m_angleX, 0));
            m_previousPressPosition = eventData.position;

        }

        public void OnEndDrag(PointerEventData eventData)
        {
            m_thridCamera.EndRotate();
        }
    }
}

