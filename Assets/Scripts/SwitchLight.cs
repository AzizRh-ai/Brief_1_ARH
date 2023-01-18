using UnityEngine;

public class SwitchLight : MonoBehaviour, IUseObj
{
    [SerializeField] private Light _light;
    [SerializeField] private MeshRenderer _lightEmissive;

    public void UseObject()
    {
        ToggleLight();
    }

    private void ToggleLight()
    {
        _light.enabled = !_light.enabled;
        if (_light.enabled)
        {
            Debug.Log("Emission ok");
            _lightEmissive.material.EnableKeyword("_EMISSION");
        }
        else
        {
            Debug.Log("Emission Non ok");

            _lightEmissive.material.DisableKeyword("_EMISSION");
        }
    }
}
