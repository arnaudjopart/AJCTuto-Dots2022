using Unity.Entities;
using UnityEngine;

namespace Components
{
    public class RotateButWithMessageComponentData : MonoBehaviour, IConvertGameObjectToEntity
    {
        public float m_rotationSpeed;
        
        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            dstManager.AddComponentData(entity, new RotateComponentData()
            {
                m_rotationSpeed = m_rotationSpeed
            });
            
            Debug.Log("Hi, I'm now an Entity");
        }
    }
}
