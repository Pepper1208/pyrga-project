using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseChessScript : MonoBehaviour
{
    [SerializeField] private GameObject highlightObj, chessObj;
    [SerializeField] private int thisChessState;
    
    void Awake()
    {
        highlightObj = transform.Find("Highlight").gameObject;
        chessObj = transform.Find("Chess").gameObject;
    }

    void Update()
    {
        highlightShow();
    }

    void highlightShow()
    {
        bool showHighlight = DataTransfer.chessState == thisChessState;
        highlightObj.SetActive(showHighlight);
    }

    void OnMouseDown()
    {
        DataTransfer.chessState = thisChessState;
    }
}
