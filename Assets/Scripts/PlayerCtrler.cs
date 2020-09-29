using UnityEngine;

/// <summary>
/// 角色移动控制
/// Author: linxinfa
/// </summary>
public class PlayerCtrler : MonoBehaviour
{
    /// <summary>
    /// 移动速度
    /// </summary>
    public float speed;

    private Transform m_transform;
    private Vector3 m_curPos;

    void Start()
    {
        m_transform = transform;
    }


    void Update()
    {
        var delta = Time.deltaTime* speed;
        m_curPos = m_transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            m_curPos += new Vector3(0, 0, 1) * delta;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            m_curPos -= new Vector3(0, 0, 1) * delta;
        }

        if (Input.GetKey(KeyCode.A))
        {
            m_curPos -= new Vector3(1, 0, 0) * delta;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            m_curPos += new Vector3(1, 0, 0) * delta;
        }
        m_transform.position = m_curPos;
    }
}
