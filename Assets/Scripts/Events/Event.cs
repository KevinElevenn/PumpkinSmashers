using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public abstract class Event : MonoBehaviour
{
    [SerializeField] private List<Waypoint> _waypoints = new List<Waypoint>();

    public UnityEvent OnEventStarted;
    public UnityEvent OnEventFinish;
    public UnityEvent<string> OnUpdateObjective;

    private List<KeyObjects> _currentKeys = new List<KeyObjects>();
    public int _currentKeysCount => _currentKeys.Count;

    void OnValidate()
    {
        FindwayPoints();
    }

    private void FindwayPoints()
    {
        _waypoints = GetComponentsInChildren<Waypoint>().ToList();
    }

    public virtual void StartEvent()
    {
        OnEventStarted.Invoke();
    }

    public virtual void StartFinish()
    {
        OnEventFinish.Invoke();
    }

    protected void UpdateObjective(string message)
    {
        OnUpdateObjective.Invoke(message);
    }

    protected Transform GetRandomSpawnPoint()
    {
        int randomIndex = Random.Range(0, _waypoints.Count);
        return _waypoints[randomIndex].transform;
    }

    protected void SpawnKey(KeyObjects objects)
    {
        Transform spawnPoint = GetRandomSpawnPoint();
        KeyObjects spawned = Instantiate(objects, spawnPoint.position, spawnPoint.rotation, transform);
        _currentKeys.Add(spawned);
    }
}
