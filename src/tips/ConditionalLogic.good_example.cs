[DefaultExecutionOrder(-1000)]
public class UpdateQueue : MonoBehaviour
{
    public static int UpdateQueueTicketNumber;
    public static int UpdateQueueIndex;
    public const int QueueLength = 5; //conditional logic updates every 5th frame

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetQueueTicket() {
        UpdateQueueTicketNumber++;
        UpdateQueueTicketNumber %= QueueLength;
        return UpdateQueueTicketNumber;
    }

    public static bool ShouldUpdate(int ticketNumber) {
        return UpdateQueueIndex == ticketNumber;
    }

    void FixedUpdate() {
        UpdateQueueIndex++;
        UpdateQueueIndex %= QueueLength;
    }
}

//...

public class AI : MonoBehaviour {
    int ticketNumber;

    void Awake() {
        ticketNumber = UpdateQueue.GetQueueTicket();
    }
    
    void FixedUpdate() {
        if (UpdateQueue.ShouldUpdate(ticketNumber))
            UpdateAiFSM();
        Move();
    }

    //...
}