using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Color targetColor = Color.red; // 적용할 색을 설정

    void Start()
    {
        // GameObject의 렌더러를 가져옴
        Renderer rend = GetComponent<Renderer>();

        if (rend != null)
        {
            // Material의 색상을 설정
            rend.material.color = targetColor;
        }
        else
        {
            Debug.LogWarning("Renderer 컴포넌트를 찾을 수 없습니다.");
        }
    }
}