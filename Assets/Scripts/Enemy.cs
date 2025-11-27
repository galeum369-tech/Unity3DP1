using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
//자동으로 원하는 컴포넌트 추가
//반ㄴ드시 필요한 컴포넌트를 실수로 삭제하는것을 방지

/// <summary>
/// 1. 위에서 아래로 이동
/// 2. 플레이어를 향해 총 발사
/// 3. 플레이어와 충돌하면 폭발효과와 함께 사라짐 (충돌처리)
/// </summary>
public class Enemy : MonoBehaviour
{



    public float speed = 5f;     //적 비행기 속도

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
