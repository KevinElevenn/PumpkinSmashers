using System;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public abstract class GunSystem : MonoBehaviour
{
    [SerializeField] public Transform PlayerCameraTransform;
    [SerializeField] protected float Range = 20f;
    [SerializeField] protected float Damage = 20f;
    [SerializeField] protected float Cooldown = 20f;
    [SerializeField] protected float Duration = 0.5f;


    private float _lastAttackTime;

    public bool TryAttack(Vector3 aimPosition, int team, GameObject instigator)
    {
        if (Time.time < _lastAttackTime + Cooldown) return false;
        _lastAttackTime = Time.time;

        Attack(aimPosition, team, instigator);

        return true;
    }

    protected virtual void Attack(Vector3 aimPosition, int team, GameObject instigator)
    {
        //play sfx

        //play animation
    }
}


