using UnityEngine;

/// <summary>
/// 小地图摄像机跟随
/// Auhor: linxinfa
/// </summary>
public class MiniMapCameraFollow : MonoBehaviour
{
    public Transform targetPlayer;

    /// <summary>
    /// 高度
    /// </summary>
    public float distanceUp = 1.3f;

    private Transform m_cameraTransform;

    void Awake()
    {
        m_cameraTransform = transform;
    }

    void LateUpdate()
    {
        if (null == targetPlayer) return;

        m_cameraTransform.position = targetPlayer.position + Vector3.up * distanceUp; 
    }
}