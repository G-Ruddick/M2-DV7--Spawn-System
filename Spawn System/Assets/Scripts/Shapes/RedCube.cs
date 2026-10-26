using UnityEngine;
using System.Collections;

public class RedCube : MonoBehaviour, ICube {
    public void Spin() {
        StartCoroutine(Movement());
    }

    private IEnumerator Movement() {
        float x = Random.Range(-0.5f, 0.5f);

        while (true) {
            this.transform.Rotate(x, 0, 0);

            yield return null;
        }
    }
}