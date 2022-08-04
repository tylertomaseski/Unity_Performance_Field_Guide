public static class GameInitialization {
    [InitializeOnLoad]
    static void GameInitializationRunner() {
        Globals.InitGlobals();
        InitClass1.SomeInitMethod();
        InitClass2.SomeInitMethod();
    }
}

public static class Globals {
    static Vector3 GlobalVal1;
    static float GlobalVal2;
    static SomeClass GlobalVal3;
    static SomeClass[] GlobalVal4;

    static void InitGlobals() {
        //initialize values
        //...
    }
}

public static class InitClass1 {
    static void SomeInitMethod() {}
}

public static class InitClass2 {
    static void SomeInitMethod() {}
}