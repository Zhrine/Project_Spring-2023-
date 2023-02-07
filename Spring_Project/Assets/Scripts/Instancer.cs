using System;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu(menuName = "InstantiateObject/Instancer")]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    public int num;
    public string targetTag;
    
    public void CreateInstance()
    {
        Instantiate(prefab);
    }
    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }
    
    public void CreateInstanceAtSpawner()
    {
        GameObject target = GameObject.FindWithTag(targetTag);
        
        if (target != null)
        {
            GameObject newObject = Instantiate(prefab, target.transform.position, target.transform.rotation);
        }
    }

    /*
    public void CreateInstanceFromList(Vector3DataList obj)
    {
        foreach (var t in obj.vector3List)
        {
            Instantiate(prefab, t.value, Quaternion.identity);
        }
    }
    public void CreateInstanceFromListCounting(Vector3DataList obj)
    {
        Instantiate(prefab, obj.vector3List[num].value, Quaternion.identity);
        num++;
        if (num == obj.vector3List.Count)
        {
            num = 0;
        }
    }
    public void CreateInstanceFromListRandomly(Vector3DataList obj)
    {
        num = Random.Range(0, obj.vector3List.Count - 1);
        Instantiate(prefab, obj.vector3List[num].value, Quaternion.identity);
        
    }
    */
}