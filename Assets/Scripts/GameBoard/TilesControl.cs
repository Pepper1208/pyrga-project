using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TilesControl : MonoBehaviour
{
    [SerializeField] private Color baseColor, offsetColor;
    [SerializeField] private SpriteRenderer thisRenderer;
    [SerializeField] private GameObject highlightObj;
    [SerializeField] public Vector2Int coordinate;
    [SerializeField] private GameObject circleChess, squareChess, triangleChess;

    void Awake()
    {
        thisRenderer = GetComponent<SpriteRenderer>();
        circleChess = transform.Find("Circle").gameObject;
        squareChess = transform.Find("Square").gameObject;
        triangleChess = transform.Find("Triangle").gameObject;
    }

    public void Init(bool isOffset)
    {
        thisRenderer.color = isOffset ? offsetColor : baseColor;
    }

    void OnMouseEnter()
    {
        highlightObj.SetActive(true);
    }

    void OnMouseExit()
    {
        highlightObj.SetActive(false);
    }

    void OnMouseDown()
    {
        Debug.Log($"Tile Being Clicked: {coordinate}");
        
        switch (DataTransfer.chessState)
        {
            case 1:
                if (circleChess.activeInHierarchy) circleChess.SetActive(false); else circleChess.SetActive(true);
                break;

            case 2:
                if (squareChess.activeInHierarchy) squareChess.SetActive(false); else squareChess.SetActive(true);
                break;

            case 3:
                if (triangleChess.activeInHierarchy) triangleChess.SetActive(false); else triangleChess.SetActive(true);
                break;

            default:
                break;
        }
    }
}
