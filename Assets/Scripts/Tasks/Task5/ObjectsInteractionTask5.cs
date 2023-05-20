using System;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены
    
    private Shelf[] _shelfs;

    private void Start()
    {
        _shelfs = FindObjectsOfType<Shelf>();
        foreach (var shelf in _shelfs)
        {
            shelf.ItemSpawned += s;
        }
    }

    private void s()
    {
        foreach (var shelf in _shelfs)
        {
            if (shelf.ItemsCount > 3)
                shelf.Fall();
        }
    }
}