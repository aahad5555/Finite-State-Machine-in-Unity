using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ExecutionState
{
    Spawn,
    Roaming,
    Dead,
    LevelUp,
    GameOver,
};
public abstract class FSM : ScriptableObject
{

    public ExecutionState ExecutionState { get; protected set; }
    public virtual void OnEnable()
    {
        ExecutionState = ExecutionState.Spawn;
    }
    public virtual bool EnterState()
    {
        ExecutionState = ExecutionState.Roaming;
        return true;
    }

    public abstract void UpdateState();
    
    public virtual bool ExitState()
    {
        ExecutionState = ExecutionState.GameOver;
        return true;
    }
}
