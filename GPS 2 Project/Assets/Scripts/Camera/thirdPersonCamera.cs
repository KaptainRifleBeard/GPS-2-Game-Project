using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CameraTool
{
    [RequireComponent(typeof(Camera))]
public class thirdPersonCamera : MonoBehaviour
    {
        [SerializeField] Transform m_target;
        [SerializeField] float m_distance;
        [SerializeField] float m_offsetAngleX;
        [SerializeField] float m_offsetAngleY;

        Vector3 m_offsetVector;
        float m_recordAngleX;
        float m_recordAngleY;

        bool m_isRotateing = false; //check is rotate?
        const float ANGLE_CONVERTER = Mathf.PI / 180;

        const float MAX_ANGLE_Y = 80;
        const float MIN_ANGLE_Y = 10;

        Transform m_trans;
        public Transform mineTransform
        {
            get
            {
                if (m_trans == null)
                {
                    m_trans = this.transform;
                }
                return m_trans;
            }
        }

        GameObject m_go;
        public GameObject mineGameObject
        {
            get
            {
                if (m_go == null)
                {
                    m_go = this.gameObject;
                }
                return m_go;
            }
        }


        void Start()
        {
            CalculateOffset();
        }

        void Update()
        {
            if (m_isRotateing)
            {
                CalculateOffset();
            }
        }

        void LateUpdate()
        {
            mineTransform.position = m_target.position + m_offsetVector;
            mineTransform.LookAt(m_target);
        }




        void CalculateOffset()
        {
            m_offsetVector.y = m_distance * Mathf.Sin(m_offsetAngleY * ANGLE_CONVERTER);
            float newRadius = m_distance * Mathf.Cos(m_offsetAngleY * ANGLE_CONVERTER);
            m_offsetVector.x = newRadius * Mathf.Sin(m_offsetAngleX * ANGLE_CONVERTER);
            m_offsetVector.z = -newRadius * Mathf.Cos(m_offsetAngleX * ANGLE_CONVERTER);
        }

        public void StartRotate()
        {
            m_isRotateing = true;

            m_recordAngleX = m_offsetAngleX;
            m_recordAngleY = m_offsetAngleY;
        }


        public void Rotate(float x, float y)
        {
            if (x != 0)
            {
                m_offsetAngleX += x;
            }
            if (y != 0)
            {
                m_offsetAngleY += y;
                m_offsetAngleY = m_offsetAngleY > MAX_ANGLE_Y ? MAX_ANGLE_Y : m_offsetAngleY;
                m_offsetAngleY = m_offsetAngleY < MIN_ANGLE_Y ? MIN_ANGLE_Y : m_offsetAngleY;
            }
        }

        public void EndRotate(bool isNeedReset = false)
        {
            m_isRotateing = false;

            if (isNeedReset)
            {
                m_offsetAngleY = m_recordAngleY;
                m_offsetAngleX = m_recordAngleX;
                CalculateOffset();
            }
        }
    }

}

