using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Abstractions;

public class MainBuilding : MonoBehaviour, IUnitProducer, ISelectable
{
    [field:SerializeField] public float Health {get; set;} = 1000;
    [field:SerializeField] public float MaxHealth {get; set;} = 1000;
    [field:SerializeField] public Sprite Icon {get; set;}

    [SerializeField] private GameObject _unitPrefab;

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

    public void ProduceUnit(Transform unitsParent)
    {
        Instantiate(_unitPrefab, new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity, unitsParent);
    }
}

