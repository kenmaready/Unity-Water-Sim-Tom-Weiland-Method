using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager Instance;

    public float amplitude = 1f;
    public float length = 2f;
    public float speed = 1f;
    public float offset = 0f;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        } else if (Instance != this) {
            Debug.Log("WaveManager Singleton already exists. Destroying new attemped instantiation.");
            Destroy(this);
        }
    }

    private void Update() {
        offset += speed * Time.deltaTime;
    }

    public float GetWaveHeight(float x) {
        return amplitude * Mathf.Sin(x / length + offset);
    }
}
