using UnityEngine;
using UnityEngine.UI;

public class CamRay : MonoBehaviour
{
    [SerializeField] private Image _reticule;
    // Update is called once per frame
    void Update()
    {
        UseTarget(FindTarget());
    }

    private IUseObj FindTarget()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider.GetComponent<IUseObj>() != null)
            {
                _reticule.color = Color.green;
                Debug.Log(" hit.collider.GetComponent<IUseObj>()" + hit.collider.GetComponent<IUseObj>());
                return hit.collider.GetComponent<IUseObj>();
            }
            else
            {
                _reticule.color = Color.white;

            }
        }
        else
        {
            _reticule.color = Color.white;
        }
        return null;
    }

    private void UseTarget(IUseObj usableObj)
    {
        if (Input.GetMouseButton(0) && usableObj != null)
        {
            usableObj.UseThis();
        }

    }
}
