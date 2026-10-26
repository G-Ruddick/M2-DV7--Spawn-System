using UnityEngine;

public interface IFactory {
    public GameObject SpawnSphere();
    public GameObject SpawnCube();
    public GameObject SpawnCylinder();
}