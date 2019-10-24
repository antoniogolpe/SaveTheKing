using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyState : ScriptableObject
{
    public abstract void stateUpdate();
}
