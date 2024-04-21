using Unity.Entities;
using Unity.NetCode;

namespace InstantPortalCharge
{
    [UpdateInGroup(typeof(ServerSimulationSystemGroup))]
    public partial class PortalChargeSystem : PugSimulationSystemBase
    {
        protected override void OnUpdate()
        {
            Entities.ForEach((ref ObjectDataCD objectDataCd) =>
                {
                    if (objectDataCd.amount < 1200)
                    {
                        objectDataCd.amount = 1200;
                    }
                })
                .WithName("PortalCharge")
                .WithBurst()
                .WithAll<PortalCD>()
                .WithNone<EntityDestroyedCD>()
                .WithEntityQueryOptions(EntityQueryOptions.IncludeDisabled)
                .Schedule();
            
            base.OnUpdate();
        }
    }
}