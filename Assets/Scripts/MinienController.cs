using UnityEngine;

public class MinienController : MonoBehaviour
{
    public GameObject[] minien = new GameObject[2];

    private void Update()
    {
        SummonMinien();
    }

    void SummonMinien()
    {

        if (Input.GetKeyDown(KeyCode.V))
        {
            if (minien[0].activeSelf)
            {
                minien[0].SetActive(!minien[0].activeSelf);
            }
        }
    }
}
