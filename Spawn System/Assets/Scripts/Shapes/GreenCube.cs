using UnityEngine;
using System.Collections;

public class GreenCube : MonoBehaviour, ICube {
    public void Spin() {
        StartCoroutine(Movement());
    }

    private IEnumerator Movement() {
        float y = Random.Range(-0.5f, 0.5f);

        while (true) {
            this.transform.Rotate(0, y, 0);

            yield return null;
        }
    }
}
