void Update() 
{
    this.transform.position += Vector3.left * (Input.GetKeyDown(KeyCode.A) ? 1f : 0f);
    this.transform.position += Vector3.right * (Input.GetKeyDown(KeyCode.D) ? 1f : 0f);

    //...
    
    this.transform.rotation = Quaternion.LookDirection(...);
    this.transform.rotation = this.transform.rotation * tiltRotation;

    //...
}