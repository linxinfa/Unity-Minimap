using UnityEngine;

/// <summary>
/// 第三人称视角摄像机跟随
/// Author: linxinfa
/// </summary>
public class PlayerCameraFollow : MonoBehaviour
{
    public Transform targetPlayer;

    /// <summary>
    /// 距离
    /// </summary>
    public float distanceAway = 1.7f;
    /// <summary>
    /// 高度
    /// </summary>
    public float distanceUp = 1.3f;
    /// <summary>
    /// 平滑度
    /// </summary>
    public float smooth = 2f;               

    private Vector3 m_targetPos;
    private Transform m_cameraTransform;
    
    void Awake()
    {
        m_cameraTransform = transform;
    }

    void LateUpdate()
    {
        if (null == targetPlayer) return;
        // 计算摄像机的目标坐标
        m_targetPos = targetPlayer.position + Vector3.up * distanceUp - targetPlayer.forward * distanceAway;

        // 插值设置坐标，有个平滑跟随效果
        m_cameraTransform.position = Vector3.Lerp(m_cameraTransform.position, m_targetPos, Time.deltaTime * smooth);

        // 设置摄像机角度，对准跟随目标
        m_cameraTransform.LookAt(targetPlayer);
    }
}