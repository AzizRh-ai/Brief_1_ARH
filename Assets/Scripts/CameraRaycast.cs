using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraRaycast : MonoBehaviour
{
    [SerializeField] private Image _reticule;

    private void Update()
    {
        UseTarget(FindUsableTarget());

    }

    // ReSharper disable Unity.PerformanceAnalysis
    private IClickable FindUsableTarget()
    {
        RaycastHit hit;
        if (!Physics.Raycast(transform.position, transform.forward, out hit))
        {
            _reticule.color = Color.white;
        }
        else
        {
            if (hit.collider.GetComponent<IClickable>() != null)
            {
                _reticule.color = Color.green;
                return hit.collider.GetComponent<IClickable>();
            }

            _reticule.color = Color.white;
        }

        return null;
    }

    // ReSharper disable Unity.PerformanceAnalysis
    private void UseTarget(IClickable usableObject)
    {
        if (Input.GetKeyDown(KeyCode.U) && usableObject != null)
        {
            usableObject.UseClickable();
        }

    }
}
