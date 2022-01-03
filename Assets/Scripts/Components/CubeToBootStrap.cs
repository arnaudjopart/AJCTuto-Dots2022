using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class CubeToBootStrap : MonoBehaviour, IConvertGameObjectToEntity, IDeclareReferencedPrefabs
{
    public GameObject m_cubePrefab;
    public GameObject m_cube2Prefab;

    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        BootStrap.m_prefab = conversionSystem.GetPrimaryEntity(m_cubePrefab);
        BootStrap.m_prefab2 = conversionSystem.GetPrimaryEntity(m_cube2Prefab);
    }

    public void DeclareReferencedPrefabs(List<GameObject> referencedPrefabs)
    {
        referencedPrefabs.Add(m_cubePrefab);
        referencedPrefabs.Add(m_cube2Prefab);
    }
}

