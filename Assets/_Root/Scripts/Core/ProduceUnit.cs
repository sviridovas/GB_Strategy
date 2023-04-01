using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProduceUnit : CommandExecutorBase<IProduceUnitCommand>
{
    public override void ExecuteSpecificCommand(IProduceUnitCommand command)
    {
        if(command.UnitsParent)
            Instantiate(command.UnitPrefab, new Vector3(Random.Range(-20, 20), 0, Random.Range(-20, 20)), Quaternion.identity, command.UnitsParent);
        else 
            Instantiate(command.UnitPrefab, new Vector3(Random.Range(-20, 20), 0, Random.Range(-20, 20)), Quaternion.identity);
    }
}

