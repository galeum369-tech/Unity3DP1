using UnityEngine;

public class MinienController : MonoBehaviour
{
    public GameObject[] minien = new GameObject[2];

    bool summon = false;

    private void Update()
    {

        SummonMinien();
        minien[0].SetActive(summon);
        minien[1].SetActive(summon);
    }

    void SummonMinien()
    {

        if (Input.GetKeyDown(KeyCode.V))
        {
            if (summon == false)
            {
                summon = true;
            }
            else summon = false;
        }
    }
}
