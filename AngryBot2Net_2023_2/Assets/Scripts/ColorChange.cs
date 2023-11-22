using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Color targetColor = Color.red; // ������ ���� ����

    void Start()
    {
        // GameObject�� �������� ������
        Renderer rend = GetComponent<Renderer>();

        if (rend != null)
        {
            // Material�� ������ ����
            rend.material.color = targetColor;
        }
        else
        {
            Debug.LogWarning("Renderer ������Ʈ�� ã�� �� �����ϴ�.");
        }
    }
}