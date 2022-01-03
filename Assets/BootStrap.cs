using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public class BootStrap : MonoBehaviour
{
    private EntityManager m_entityManager;

    public static Entity m_prefab;
    public static Entity m_prefab2;

    // Start is called before the first frame update
    void Start()
    {
        m_entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        //var entityPrefab = m_entityManager.GetComponentData<PrefabConversionResultCompData>(m_prefab);
        var item = m_entityManager.Instantiate(m_prefab2);
        m_entityManager.SetComponentData(item, new Translation
        {
            Value = new float3(0,1.5f,0)
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
