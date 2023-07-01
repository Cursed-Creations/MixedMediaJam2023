using UnityEngine;

public sealed class GameClock : MonoBehaviour {
    public static float time { get; private set; } = 9;
    public static float deltaTime;
    public static bool isEnabled;

    [SerializeField]
    int startTime = 9;
    [SerializeField]
    int multiplier = 1;

    void OnEnable() {
        time = startTime;
        isEnabled = true;
    }

    void Update() {
        if (isEnabled) {
            deltaTime = Time.deltaTime * multiplier;
            time += deltaTime;
        }
    }
}
