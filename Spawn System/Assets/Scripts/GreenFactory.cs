using UnityEngine;

public class GreenFactory : MonoBehaviour, IFactory {
    public GameObject sphere, cube, cylinder;

    public GameObject SpawnSphere() {
        return Instantiate(sphere);
    }

    public GameObject SpawnCube() {
        return Instantiate(cube);
    }

    public GameObject SpawnCylinder() {
        return Instantiate(cylinder);
    }
}