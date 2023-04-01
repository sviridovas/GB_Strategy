using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Abstractions;

public class SelectUnit : MonoBehaviour, ISelectable
{
    [field:SerializeField] public float Health {get; set;} = 1000;
    [field:SerializeField] public float MaxHealth {get; set;} = 1000;
    [field:SerializeField] public Sprite Icon {get; set;}

    private Outline _outline;

    void Awake()
    {
        _outline = GetComponent<Outline>();
        _outline.enabled = false;
    }

    public void SetOutlined(bool enabled)
    {
        _outline.enabled = enabled;
    }
}
