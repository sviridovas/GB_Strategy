using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Abstractions;

public class CommandButtonsPresenter : MonoBehaviour
{
    [SerializeField] private SelectableValue _selectable;
    [SerializeField] private CommandButtonsView _view;
    [SerializeField] private Transform _unitsParent;
    [SerializeField] private AssetsContext _context;

    private ISelectable _currentSelectable;

    void Start()
    {
        _selectable.OnSelected += onSelected;
        onSelected(_selectable.CurrentValue);
        _view.OnClick += onButtonClick;
    }

    private void onSelected(ISelectable selectable)
    {
        if (_currentSelectable == selectable)
        {
            return;
        }
        _currentSelectable = selectable;

        _view.Clear();
        if (selectable != null)
        {
            var commandExecutors = new List<ICommandExecutor>();
            commandExecutors.AddRange((selectable as Component).GetComponentsInParent<ICommandExecutor>());
            _view.MakeLayout(commandExecutors);
        }
    }


    private void onButtonClick(ICommandExecutor commandExecutor)
    {
        var unitProducer = commandExecutor as CommandExecutorBase<IProduceUnitCommand>;
        if (unitProducer != null)
        {
            unitProducer.ExecuteSpecificCommand(_context.Inject(new ProduceUnitCommandHeir(_unitsParent)));
            return;
        }
        var unitMover = commandExecutor as CommandExecutorBase<IMoveCommand>;
        if (unitMover != null)
        {
            unitMover.ExecuteSpecificCommand(null);
            return;
        }
        var unitAttacker = commandExecutor as CommandExecutorBase<IAttackCommand>;
        if (unitAttacker != null)
        {
            unitAttacker.ExecuteSpecificCommand(null);
            return;
        }
        var unitStoper = commandExecutor as CommandExecutorBase<IStopCommand>;
        if (unitStoper != null)
        {
            unitStoper.ExecuteSpecificCommand(null);
            return;
        }
        var unitPatroler = commandExecutor as CommandExecutorBase<IPatrolCommand>;
        if (unitPatroler != null)
        {
            unitPatroler.ExecuteSpecificCommand(null);
            return;
        }

        throw new ApplicationException($"{nameof(CommandButtonsPresenter)}.{nameof(onButtonClick)}: Unknown type of commands executor: {commandExecutor.GetType().FullName}!");
    }
}
