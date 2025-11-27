using UnityEngine;

public class MinienConR : MonoBehaviour
{
    public Transform player;

    public float distanceX = 1.5f;   // x거리
    public float moveSpeed = 6f;          // 따라가는 속도
    public float distanceY = 1.2f;      // Y거리



    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    void FollowPlayer()
    {
        if (player == null) return;

        Vector3 targetPos = player.position;
        targetPos.x += distanceX;
        targetPos.y += distanceY;
        targetPos.z = 0;

        transform.position = Vector3.Lerp(
            transform.position,
            targetPos,
            Time.deltaTime * moveSpeed
        );
    }
}
