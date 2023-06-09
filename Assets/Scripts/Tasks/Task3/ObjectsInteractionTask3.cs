using System;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    // TODO: Получите доступ ко всем объектам сцены со скриптом Lamp
    // TODO: При нажатии на кнопку 2 на клавиатуре вызывайте у всех полученных объектов метод Interact

    private Lamp[] _lamps;
    private bool _isKeyPressed;

    private void Start()
    {
        _lamps = FindObjectsOfType<Lamp>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha2))
        {
            if (!_isKeyPressed)
            {
                foreach (var lamp in _lamps)
                {
                    lamp.Interact();
                }

                _isKeyPressed = true;
            }
        }
        else
            _isKeyPressed = false;
    }
}