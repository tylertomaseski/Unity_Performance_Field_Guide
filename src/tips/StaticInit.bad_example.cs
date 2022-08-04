public static class Globals {
    static Vector3 GlobalVal1 = new Vector3(...);
    static float GlobalVal2 = ...;
    static SomeClass GlobalVal3 = ...;
    static SomeClass[] GlobalVal4 = new SomeClass[...];

    static Globals() {}
}

public static class InitClass1 {
    [InitializeOnLoad]
    static void SomeInitMethod() {}
}

public static class InitClass2 {
    [InitializeOnLoad]
    static void SomeInitMethod() {}
}