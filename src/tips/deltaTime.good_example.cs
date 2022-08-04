[DefaultExecutionOrder(-1000)]
public class MyTime : MonoBehaviour
{
    public static float deltaTime;

    void Update() 
    {
        deltaTime = Time.deltaTime;
    }

    void FixedUpdate() 
    {
        deltaTime = Time.deltaTime;
    }
}

public class SomeGameplayClass : MonoBehaviour 
{
    void Update() {
        //..
        this.timer += MyTime.deltaTime;
        //...
    }
}