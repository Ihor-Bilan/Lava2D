using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAppearance : MonoBehaviour
{
    public Sprite newSprite; // Новий спрайт, на який ви хочете змінити кульку
    public Material newMaterial; // Новий матеріал, який ви хочете застосувати до кульки
    public int frameToChange = 100; // Кадр, на якому ви хочете змінити вигляд кульки

    private bool appearanceChanged = false;

    void Update()
    {
        // Перевіряємо, чи досягнуто кадру, на якому потрібно змінити вигляд
        if (!appearanceChanged && Time.frameCount >= frameToChange)
        {
            appearanceChanged = true;

            // Змінюємо спрайт кульки на новий спрайт, якщо він був заданий
            if (newSprite != null)
            {
                GetComponent<SpriteRenderer>().sprite = newSprite;
            }

            // Змінюємо матеріал кульки на новий матеріал, якщо він був заданий
            if (newMaterial != null)
            {
                GetComponent<SpriteRenderer>().material = newMaterial;
            }
        }
    }
}
