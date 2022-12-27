using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopUnit : CommandExecutorBase<IStopCommand>
{
    public override void ExecuteSpecificCommand(IStopCommand command)
    {
        Debug.Log("Stop");
    }
}
