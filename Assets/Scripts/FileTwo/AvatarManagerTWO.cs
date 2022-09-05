using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarManagerTWO : AvatarManager
{
    public static AvatarManagerTWO instanceTWO;

    public override void InstanceSeter()
    {
        instanceTWO = this;
    }
}
