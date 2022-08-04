TMP_Text textComponent;
int lastVal = -1;

void Update() {
    int val = (int)Time.time;
    if (val != lastVal) {
        lastVal = val;
        this.textComponent.SetText(val);
    }
}