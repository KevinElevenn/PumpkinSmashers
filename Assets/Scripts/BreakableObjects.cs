using NUnit.Framework;
using UnityEngine;

public class BreakableObjects : MonoBehaviour
{
    [SerializeField] private GameObject[] Objects;
    [SerializeField] private string _tagFilter = "Breaker";
    void Awake()
    {
        Objects[0].SetActive(true);
        Objects[1].SetActive(false);
    }

    void OnCollisionEnter(Collision other)
    {
        if ( other.gameObject.tag == _tagFilter)
        {
        Objects[0].SetActive(false);
        Objects[1].SetActive(true);
        }
    }

}
