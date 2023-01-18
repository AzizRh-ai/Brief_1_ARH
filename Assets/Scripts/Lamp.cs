using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour, IClickable
{
    [SerializeField] private Light _light;

    [SerializeField] private MeshRenderer  _lightEmissive;

    public void UseClickable()
    {
        Debug.Log("On UseClickable from Lamp");
        _light.enabled = !_light.enabled;
        if (_light.enabled)
        {
            _lightEmissive.material.EnableKeyword("_EMISSION");
        }
        else
        {
            _lightEmissive.material.DisableKeyword("_EMISSION");
        }
    }
}