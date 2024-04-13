using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using DG.Tweening;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] Transform m_DoorTransform;
    [SerializeField] Vector3 m_PositionOpenOffset;
    [SerializeField] GameObject CorrectKey;

    private Vector3 m_PositionClose;
    private Vector3 m_PositionOpen;

    bool m_IsOpening;
    float m_Alpha;

    private void Awake()
    {
        m_PositionClose = m_DoorTransform.position;
        m_PositionOpen = m_PositionOpenOffset + m_PositionClose;
    }

    private void Update()
    {
        if (m_IsOpening) m_Alpha += Time.deltaTime;
        else m_Alpha -= Time.deltaTime;
        m_Alpha = Mathf.Clamp(m_Alpha, 0, 1);

        m_DoorTransform.position = Vector3.Lerp(m_PositionClose, m_PositionOpen, m_Alpha);
    }

    public void DoorOnRestart()
    {
        m_IsOpening = false;
        m_DoorTransform.position = m_PositionClose;
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.name == "Player") other.GetComponent<week6.Player>().Damage();
        if (CorrectKey.activeInHierarchy == false)
        {
            Debug.Log("Door Trigger has been triggered");
            //m_DoorTransform.position = m_PositionClose + m_PositionOpen;
            m_IsOpening = true;
            //DOTween.Kill(m_DoorTransform, "DoorTween");
            //m_DoorTransform.DOMove(m_PositionOpen, 1f).SetId("DoorTween");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (CorrectKey.activeInHierarchy == false)
        {
            Debug.Log("Door Trigger is still being triggered");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (CorrectKey.activeInHierarchy == false)
        {
            Debug.Log("Something has left the trigger");
            //m_DoorTransform.position = m_PositionClose;
            m_IsOpening = false;
            //DOTween.Kill(m_DoorTransform, "DoorTween");
            //m_DoorTransform.DOMove(m_PositionClose, 1f).SetId("DoorTween");
        }
    }

}
