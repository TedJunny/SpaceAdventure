using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{

    [SerializeField] Transform m_tfGunBody = null;
    [SerializeField] float m_range = 0f;
    [SerializeField] LayerMask m_layerMask = 0;
    public float m_spinSpeed = 0f;

    // 연사속도
    public float m_fireRate = 0f;
    // 연사변수
    float m_currentFireRate;

    Transform m_tfTarget = null;
    public Transform m_tfHead = null;

    public GameObject bulletFactory;
    public Transform firePosition;

    void SearchEnemy()
    {
        Collider[] t_cols = Physics.OverlapSphere(transform.position, m_range, m_layerMask);
        Transform t_shortestTarget = null;

        if (t_cols.Length > 0)
        {
            float t_shortestDistance = Mathf.Infinity;
            foreach (Collider t_colTarget in t_cols)
            {
                float t_distance = Vector3.SqrMagnitude(transform.position - t_colTarget.transform.position);
                if (t_shortestDistance > t_distance)
                {
                    t_shortestDistance = t_distance;
                    t_shortestTarget = t_colTarget.transform;
                }
            }
        }

        m_tfTarget = t_shortestTarget;

    }

    // Start is called before the first frame update
    void Start()
    {
        // 시작과 동시에 연사변수에 연사속도를 넣어준다
        m_currentFireRate = m_fireRate;

        InvokeRepeating("SearchEnemy", 0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (m_tfTarget == null)
        {
            m_tfGunBody.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
        }

        else
        { 
            Quaternion t_lookRotation = Quaternion.LookRotation(m_tfTarget.position - m_tfHead.position);
            Vector3 t_euler = Quaternion.RotateTowards(m_tfGunBody.rotation, t_lookRotation, m_spinSpeed * Time.deltaTime).eulerAngles;
            m_tfGunBody.rotation = Quaternion.Euler(0, t_euler.y, 0);

            // 터렛이 조준해야될 최종 방향을 잡는다.
            Quaternion t_fireRotation = Quaternion.Euler(0, t_lookRotation.eulerAngles.y, 0);

            // 현재 포신의 방향과 조준해야될 방향의 각도 차를 계산한다.
            if (Quaternion.Angle(m_tfGunBody.rotation, t_fireRotation) < 5f)
            {
                m_currentFireRate -= Time.deltaTime;
                if (m_currentFireRate <= 0)
                {
                    m_currentFireRate = m_fireRate;

                    GameObject bullet = Instantiate(bulletFactory);

                    bullet.transform.position = firePosition.position;
                }
            }

        }
    }
}
