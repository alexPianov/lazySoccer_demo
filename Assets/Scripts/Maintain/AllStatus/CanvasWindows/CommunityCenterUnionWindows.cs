using LazySoccer.Status;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LazySoccer.Windows
{
    public class CommunityCenterUnionWindows : BaseWindows<StatusCommunityCenterUnion>
    {
        public override void Awake()
        {
            if (baseStatus == null)
                baseStatus = ServiceLocator.GetService<CommunityCenterUnionStatus>();
            base.Awake();
        }
    }
}
