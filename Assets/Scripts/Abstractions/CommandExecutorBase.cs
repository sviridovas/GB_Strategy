using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CommandExecutorBase<T> : MonoBehaviour, ICommandExecutor where T : ICommand
{
    public void ExecuteCommand(object command) => ExecuteSpecificCommand((T)command);
    public abstract void ExecuteSpecificCommand(T command);
}