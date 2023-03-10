using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContorller : MonoBehaviour
{
    [SerializeField] GameObject[] ObjectGround;
    [SerializeField] int[] NumberOfPass;
    [SerializeField] bool[] BoolOfPass;
    private void Start()
    {
        for (int i = 0; i < ObjectGround.Length; i++)
        {
            if (ObjectGround[i].activeInHierarchy)
            {
                NumberOfPass[i] = i;
                BoolOfPass[i] = true;
            }
        }
    }
}
