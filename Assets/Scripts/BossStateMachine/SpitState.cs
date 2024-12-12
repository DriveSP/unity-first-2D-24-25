using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpitState : State
{
    public SpitState(BossController Boss) : base(Boss) {}

    private GameObject spit;
    private Vector2 spitPos;

    public override void Entry()
    { 
        base.Entry();
        spit = Boss.GetSpit();
        spitPos = (Vector2)Boss.transform.position + (new Vector2(0,0.7f));
        Debug.Log("Spit State Entered");

        // instanciar proyectil
        Object.Instantiate(spit, spitPos, Quaternion.identity);
        // siguiente estado
        Boss.ChangeStateKey(States.Recovery);
    }
}
