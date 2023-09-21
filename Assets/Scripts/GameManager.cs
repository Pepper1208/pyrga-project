using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        BoardInit();
    }

    void BoardInit(int mode = 0)
    {
        switch (mode)
        {
            case 0:
                DataTransfer.board = new int[4,4,3];
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            DataTransfer.board[i,j,k] = 0;
                        }
                    }
                }
                break;

            default:
                break;
        }
        
    }
}
