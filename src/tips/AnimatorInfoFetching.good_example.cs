int Key_PropertyName;

void Awake() 
{
    Key_PropertyName = Animator.StringToHash("PropertyName");
}

void Update() 
{
    Animator.SetFloat(Key_PropertyName, ...)
}