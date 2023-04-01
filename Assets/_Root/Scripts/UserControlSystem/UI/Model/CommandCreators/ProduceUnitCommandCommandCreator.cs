using System;
using Zenject;
using UnityEngine;
public class ProduceUnitCommandCommandCreator : CommandCreatorBase<IProduceUnitCommand>
{
    [Inject] private AssetsContext _context;
    // [Inject] private Transform _unitsParent;

    protected override void classSpecificCommandCreation(Action<IProduceUnitCommand> creationCallback)
    {
        creationCallback?.Invoke(_context.Inject(new ProduceUnitCommandHeir(null)));
    }
}