static Dictionary<string, object> lookupDictionary = ...;

public string ID;

void Awake() {
    lookupDictionary[ID] = this;
}

...

static void SomeFunc(string ID) {
    var obj = lookupDictionary[ID];
    
    ...
    
}