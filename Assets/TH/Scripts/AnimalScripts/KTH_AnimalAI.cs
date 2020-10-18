using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KTH_AnimalAI : MonoBehaviour
{
    NavMeshAgent m_animal = null;

    [SerializeField] Transform[] m_tfWayPoints = null;
    int m_count = 0;


    Transform m_target = null;

    public void SetTarget(Transform p_target)
    {
        CancelInvoke();
        m_target = p_target;
    }

    public void RemoveTarget()
    {
        m_target = null;
        InvokeRepeating("MoveToNextWayPoint", 0f, 2f);
    }

    void MoveToNextWayPoint()
    {
        if (m_target == null)
        {
            if (m_animal.velocity == Vector3.zero)
            {
                m_animal.SetDestination(m_tfWayPoints[m_count++].position);

                if (m_count >= m_tfWayPoints.Length)
                    m_count = 0;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        m_animal = GetComponent<NavMeshAgent>(); 
        InvokeRepeating("MoveToNextWayPoint", 0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        if(m_target != null)
        {
            m_animal.SetDestination(m_target.position);
        }
    }
}
    