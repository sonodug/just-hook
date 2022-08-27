using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Platform : Environment
{
    protected GrapplingRope _connectedRope { get; private set; }

    public override void InitializeRopeConnection(GrapplingRope grapplingRope)
    {
        _connectedRope = grapplingRope;
    }

    public override bool TryBreakConnection()
    {
        if (_connectedRope)
        {
            if (_connectedRope.IsGrappling)
            {
                _connectedRope.Affectable = true;
                _connectedRope.enabled = false;
                return true;
            }
        }

        return false;
    }
}
