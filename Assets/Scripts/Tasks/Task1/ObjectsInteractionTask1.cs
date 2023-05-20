using System;
using UnityEngine;

public class ObjectsInteractionTask1 : MonoBehaviour
{
    // TODO: Получите доступ к объекту со скриптом Refrigerator при помощи атрибута [SerializeField]
    // TODO: При нажатии на кнопку 1 на клавиатуре вызывайте у него метод Interact
    
    [SerializeField] private Refrigerator _refrigerator;
    private bool _isKeyPressed;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            if (!_isKeyPressed)
            {
                _refrigerator.Interact();
                _isKeyPressed = true;
            }
        }
        else
            _isKeyPressed = false;
    }
}
