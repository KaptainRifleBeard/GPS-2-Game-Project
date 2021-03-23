using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


namespace Test
{
    public class EyesComtroller : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
    {
        [SerializeField] CameraTool.thirdPersonCamera m_thridCamera;

        const float DRAG_TO_ANGLE = 0.5f;
        Vector2 m_previousPressPosition;
        float m_angleX, m_angleY;
        Image m_image;

        void Start()
        {
            m_image = GetComponent<Image>();
        }


        // Update is called once per frame
        void Update()
        {

        }

        public void OnDrag(PointerEventData eventData)
        {
            m_angleX = (eventData.position.x - m_previousPressPosition.x) * DRAG_TO_ANGLE;
            m_angleY = (eventData.position.y - m_previousPressPosition.y) * DRAG_TO_ANGLE;
            m_thridCamera.Rotate(-m_angleX, -m_angleY);
            m_previousPressPosition = eventData.position;
        
        }

            public void OnBeginDrag(PointerEventData eventData)
        {
            m_previousPressPosition = eventData.position;
            m_thridCamera.StartRotate();
            m_image.color = Color.gray;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            m_image.color = Color.white;
            m_thridCamera.EndRotate(true);
        }
    }
}

