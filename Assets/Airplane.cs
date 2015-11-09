
public class Airplane {


    public int x, y;
    public int cargo= 0;
    public int cargoCapacity = 90;
    public bool active;
    private int xMoveDirection; 
    private int yMoveDirection;

    public void SetMoveDirection(int xMoveDir, int yMoveDir)
    {
            xMoveDirection = xMoveDir; 
            yMoveDirection = yMoveDir; 
    }

    public void MoveNow()
    {
        x = x + xMoveDirection;
        y = y + yMoveDirection;
        xMoveDirection = 0;
        yMoveDirection = 0;
    }
       
   

    //}
    
}

