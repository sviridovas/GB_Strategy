using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolUnit : CommandExecutorBase<IPatrolCommand>
{
    public override void ExecuteSpecificCommand(IPatrolCommand command)
    {
        Debug.Log("Patrol");
    }
}
