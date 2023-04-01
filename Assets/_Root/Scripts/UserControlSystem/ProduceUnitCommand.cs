using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProduceUnitCommand : IProduceUnitCommand
{
    public GameObject UnitPrefab => _unitPrefab;
    [InjectAsset("MainBuilding")] protected GameObject _unitPrefab;

    public Transform UnitsParent { get; }

    public ProduceUnitCommand(Transform unitsParent)
    {
        UnitsParent = unitsParent;
    }
}
