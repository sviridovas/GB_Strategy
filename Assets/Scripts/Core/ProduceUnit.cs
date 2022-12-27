using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProduceUnit : CommandExecutorBase<IProduceUnitCommand>
{
    public override void ExecuteSpecificCommand(IProduceUnitCommand command)
    {
        Instantiate(command.UnitPrefab, new Vector3(Random.Range(-20, 20), 0, Random.Range(-20, 20)), Quaternion.identity, command.UnitsParent);
    }
}

