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
    [SerializeField] private Transform _unitsParent;

    public void ProduceUnit()
    {
        Instantiate(_unitPrefab, new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity, _unitsParent);
    }
}

