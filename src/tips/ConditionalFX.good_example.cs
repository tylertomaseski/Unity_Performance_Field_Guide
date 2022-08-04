void SpawnFX() {
    //only spawn if framerate is higher than 25fps
    if (Time.deltaTime < 1.0f / 25.0f)
        GameObject.Instantiate(/*...*/);
}