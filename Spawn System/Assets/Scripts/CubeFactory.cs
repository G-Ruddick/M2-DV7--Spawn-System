using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CubeFactory : MonoBehaviour, IFactory {
    [SerializeField] private List<GameObject> prefabs = new List<GameObject>();

    public void Spawn(int unit) {
        GameObject cube = Instantiate(prefabs[unit], Vector3.zero, Quaternion.identity);
        StartCoroutine(Spin(cube));
    }
    public void Spawn(int unit, Vector3 spawnLocation) {
        GameObject cube = Instantiate(prefabs[unit], spawnLocation, Quaternion.identity);
        StartCoroutine(Spin(cube));
    }

    IEnumerator Spin(GameObject cube) {
        float x = Random.Range(-0.5f, 0.5f);
        float y = Random.Range(-0.5f, 0.5f);
        float z = Random.Range(-0.5f, 0.5f);

        while (true) {
            cube.transform.Rotate(x, y, z);

            yield return null;
        }
    }
}
