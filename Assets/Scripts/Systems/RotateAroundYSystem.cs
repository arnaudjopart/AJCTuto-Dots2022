using Components;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

namespace Systems
{
    public class RotateAroundYSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            var deltaTime = Time.DeltaTime;

            Entities.WithAll<RotateComponentData>().ForEach((ref Rotation _rotation, in RotateComponentData _data) =>
            {
                _rotation.Value = math.mul(_rotation.Value, quaternion.Euler(0, _data.m_rotationSpeed * deltaTime, 0));
            }).Schedule();
        }
    }
}
