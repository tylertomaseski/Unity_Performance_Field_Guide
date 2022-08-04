[BurstCompile]
public struct TransformJob : IJobParallelForTransform
{      
    public void Execute(int index, TransformAccess transform)
    {
        Vector3 position = transform.position;
        Quaternion rotation = transform.rotation;

        //
        // Your logic
        //

        transform.position = position;
        transform.rotation = rotation;
    }
}
