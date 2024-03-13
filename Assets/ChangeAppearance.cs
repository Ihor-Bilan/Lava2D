using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAppearance : MonoBehaviour
{
    public Sprite newSprite; // ����� ������, �� ���� �� ������ ������ ������
    public Material newMaterial; // ����� �������, ���� �� ������ ����������� �� ������
    public int frameToChange = 100; // ����, �� ����� �� ������ ������ ������ ������

    private bool appearanceChanged = false;

    void Update()
    {
        // ����������, �� ��������� �����, �� ����� ������� ������ ������
        if (!appearanceChanged && Time.frameCount >= frameToChange)
        {
            appearanceChanged = true;

            // ������� ������ ������ �� ����� ������, ���� �� ��� �������
            if (newSprite != null)
            {
                GetComponent<SpriteRenderer>().sprite = newSprite;
            }

            // ������� ������� ������ �� ����� �������, ���� �� ��� �������
            if (newMaterial != null)
            {
                GetComponent<SpriteRenderer>().material = newMaterial;
            }
        }
    }
}
