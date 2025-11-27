using UnityEngine;

public class TailCon : MonoBehaviour
{
    public Transform target;

    public float speed = 3f;

    public float stopDistance = 0.05f;

    // Update is called once per frame
    void Update()
    {
        ////타겟 방향 구하기(벡터의 뺄셈
        ////타겟 위치 - 내 위치 = 뱡향 백터
        //Vector3 dir = transform.position - target.position;
        //dir.Normalize();/
        //transform.position += dir * speed * Time.deltaTime;
        //transform.Translate(dir * speed *  Time.deltaTime);

        FollowTarget();
    }

    void FollowTarget()
    {
        Vector3 dir = transform.position - target.position;
        float distance = dir.magnitude;

        //현재 거리가 멈출 거리보다 클 때만 이동
        if (distance > stopDistance)
        {
            dir.Normalize();
            transform.Translate(dir * speed * Time.deltaTime);
        }
    }
}
