using System.Linq;
using UnityEngine;

public class Targatable : MonoBehaviour
{
    [SerializeField] public int Team {get; private set;} = 0;
    [SerializeField] public bool IsTargetable {get; set;} = true ;
    [SerializeField] public Transform VisibilityTransform {get; private set;}

    void OnValidate()
    {
        if(VisibilityTransform == null)
        {
            // find all child transforms and return the first one called "Spine_02"
            //were using LINQ to find the bone, its expensive so dont use it during runtime
            VisibilityTransform = transform.GetComponentsInChildren<Transform>().
                Where(t => t.name.Equals("Spine_02")).FirstOrDefault();
        }
    }
}
