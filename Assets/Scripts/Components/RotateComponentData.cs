using Unity.Entities;

namespace Components
{
    [GenerateAuthoringComponent]
    public struct RotateComponentData : IComponentData
    {
        public float m_rotationSpeed;
    }
}
