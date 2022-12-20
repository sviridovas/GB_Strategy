using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Abstractions;

public class MouseInteractionPresenter : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private SelectableValue _selectedObject;

    
    void Update()
    {
        if(!Input.GetMouseButtonUp(0))
            return;
        
        var hits = Physics.RaycastAll(_camera.ScreenPointToRay(Input.mousePosition));
        if(hits.Length == 0)
            return;

        var selectable = hits.Select(hit => hit.collider.GetComponent<ISelectable>()).FirstOrDefault(c => c != null);
        // if(selectable == default)
        //     return;

        // selectable.ProduceUnit();
        _selectedObject.SetValue(selectable);
    }
}
