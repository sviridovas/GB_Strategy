using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Abstractions;

public class MoveUnit : CommandExecutorBase<IMoveCommand>
{
    public override void ExecuteSpecificCommand(IMoveCommand command)
    {
        Debug.Log("Move");
    }
}
