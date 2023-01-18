using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelChanger : MonoBehaviour, IClickable
{
    [SerializeField] private GameObject[] _prefabs;
    [SerializeField] private GameObject _actualObject;
    private int _actualPrefab = -1;

    private void ChangeObject()
    {
        if(_actualObject != null)
        { 
            Destroy(_actualObject); 
        }
        
        Debug.Log("_actualPrefab:"+_actualPrefab);
        
        _actualPrefab++;
        if (_actualPrefab >= _prefabs.Length)
        {
            _actualPrefab = 0;
        }

        _actualObject = Instantiate(_prefabs[_actualPrefab],transform.position,transform.rotation);
    }

    public void UseClickable()
    {
        ChangeObject(); 
    }
}
