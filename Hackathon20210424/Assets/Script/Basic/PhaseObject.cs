using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class PhaseObject : MonoBehaviour
{
    [SerializeField] private NowGamePhase phase;
    protected void Update()
    {
        if (phase.phase.Value == PhaseKind.playerturn) PlayerUpdate();
        if (phase.phase.Value == PhaseKind.enemyturn) EnemyUpdate();
        if (phase.phase.Value == PhaseKind.menu) MenuUpdate();
        if (phase.phase.Value == PhaseKind.gameover) GameOverUpdate();
    }

    protected virtual void PlayerUpdate()
    {

    }
    protected virtual void EnemyUpdate()
    {

    }
    protected virtual void MenuUpdate()
    {

    }
    protected virtual void GameOverUpdate()
    {

    }

}


