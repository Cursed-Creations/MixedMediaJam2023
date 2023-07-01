using UnityEngine;

public abstract class ModalityBase : ScriptableObject {

    int value;

    public void Increment() {
        value++;
    }

    [SerializeField]
    GameObject prefab;

    [SerializeField]
    public string text = "Now doing: Nothing";

    GameObject instance;

    public void TryStart(GameObject button) {
        if (CanOpen(out string errorText)) {
            HUD.currentModality = this;
        } else {
            HUD.status = errorText;
        }
    }

    public void Start() {
        instance = Instantiate(prefab);
        HUD.status = text;
    }

    public void Close() {
        if (instance) {
            Destroy(instance);
            instance = null;
        }
    }

    public abstract bool CanOpen(out string errorText);
}
