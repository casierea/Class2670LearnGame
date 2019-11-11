using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class CharacterMoveWhenGrounded : CharacterBase
{
    public override void Move()
    {
        Grounded();
        base.Move();
    }

    public override void Grounded()
    {
        base.Grounded();
    }
}
