using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindBarrierReinforcement.Common.Attributes;

namespace WindBarrierReinforcement.DataModels.NSPage04
{
    public enum EHookType
    {
        [DisplayByResourceKey(ResourceKey = "HookType_A")]
        A,
        [DisplayByResourceKey(ResourceKey = "HookType_B")]
        B,
        [DisplayByResourceKey(ResourceKey = "HookType_C")]
        C
    };
}
