using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SphereFactory : MonoBehaviour, IFactory {
    [SerializeField] private List<GameObject> prefabs = new List<GameObject>();

    public void Spawn(int unit) {
        GameObject sphere = Instantiate(prefabs[unit], Vector3.zero, Quaternion.identity);
        StartCoroutine(Expand(sphere));
    }
    public void Spawn(int unit, Vector3 spawnLocation) {
        GameObject sphere = Instantiate(prefabs[unit], spawnLocation, Quaternion.identity);
        StartCoroutine(Expand(sphere));
    }

    IEnumerator Expand(GameObject sphere) {
        bool expand = true;
        
        while (true) {
            yield return null;

            if (expand) {
                sphere.transform.localScale += sphere.transform.localScale * 0.005f;
                
                if (sphere.transform.localScale.x < 5) {
                    continue;
                }

                expand = false;
            }
            
            sphere.transform.localScale -= sphere.transform.localScale * 0.005f;
                
            if (sphere.transform.localScale.x > 0.5f) {
                continue;
            }

            expand = true;
        }
    }
}
