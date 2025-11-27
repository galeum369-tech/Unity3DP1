using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// 1. 아이템 먹어서 보조비행기가 새롭게 생성되는 기능(On/Off)
/// 2. 보조비행기는 일정 시간마다 자동으로 총알 발사
/// </summary>
public class PlayerClone : MonoBehaviour
{
    public GameObject clone;           //보조비행기 오브젝트

    public GameObject bulletFactory;   //총알 공장

    public float fireTime = 1f;        //총알 발사 간격 (1초에 한번)

    float tiemer = 0f;                 //시간 누적 변수


    // Update is called once per frame
    void Update()
    {
        //아이템 먹었을 때 보조비행기 생성
        CreatClone();

        AutoFire();
    }
    
    void CreatClone()
    {
        //간단하게 ESC키를 누르면 보조비행기 생성
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //clone.SetActive(true);
            clone.SetActive(!clone.activeSelf); //토글형식으로 


            //bool isJump = !isJump;   //토글 형식
        }
    }

    void AutoFire()
    {
       if (clone.activeSelf)
        {
            tiemer += Time.deltaTime;
            if (tiemer >= fireTime)
            {
                tiemer = 0f;

                GameObject[] bullet = new GameObject[clone.transform.childCount];
                for (int i = 0; clone.transform.childCount > 0; i++)
                {
                    bullet[i] = Instantiate(bulletFactory);
                    bullet[i].transform.position = clone.transform.GetChild(i).position;
                }
            }
        }
    }

}
