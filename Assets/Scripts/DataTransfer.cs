using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataTransfer
{
    public static int[,,] board;
    /*
    Top-Left Corner: (0, 0)
    i: Horizontal Axis
    j: Vertical Axis
    k: State (1: Circle, 2: Square, 3: Triangle/Arrow)
    */

    public static int chessState;
    // 1: Circle, 2: Square, 3: Triangle/Arrow
}