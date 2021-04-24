using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
public class NowGamePhase : MonoBehaviour
{
    public ReactiveProperty<PhaseKind> phase = new ReactiveProperty<PhaseKind>();
}

public enum PhaseKind
{
    playerturn, enemyturn, menu, gameover, clear
}