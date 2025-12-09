//ing System.Collections.Generic;
//ing UnityEngine;
//ing UnityEngine.Events;
//ing UnityEngine.InputSystem;
//
//abstract makes it so you can only inherit
//blic abstract class Event : MonoBehaviour
//
//  [SerializeField] private List<Waypoint> _waypoints = new List<Waypoint>();
//
//used in editor to config events
//blic UnityEvent OnEventStarted;
//blic UnityEvent OnEventFinish;
//blic UnityEvent<string> OnUpdateObjective;
//
//ivate List<KeyObjects> _currentKeys = new List<KeyObjects>();
//blic int _currentKeysCount => _currentKeys.Count;
//  void OnValidate()
//  {
//      FindwayPoints();
//
//
//rivate void FindwayPoints()
//
//   //.ToList() can be expensive but we doing this during edit only mode
//   _waypoints = GetComponentsInChildren<_waypoints>().ToList();
//
//
//ublic virtual void StartEvent()
//
//   OnEventStarted.Invoke();
//
//   public virtual void StartFinish()
//
//   OnEventFinish.Invoke();
//
//
//rotected void UpdateObjective(string message)
//
//   OnUpdateObjective.Invoke(message);
//
//
//rotected Transform GetRandomSpawnPoint()
//
//   int randomIndex = Random.Range(0, _waypoints.Count);
//   return _waypoints[randomIndex].transfrom;
//
//
//rotected void SpawnKey(KeyObjects objects)
//
//   Transform spawnPoint = GetRandomSpawnPoint();
//   KeyOjects spawned = Instantiate(objects, spawnPoint.position, spawnPoint.rotation, transform);
//
//   _currentKeys.Add(spawned);
//
//   
//
//
//