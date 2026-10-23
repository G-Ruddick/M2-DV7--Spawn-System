using UnityEngine;

public interface IFactory {
    public void Spawn(int unit);
    public void Spawn(int unit, Vector3 spawnLocation);
}