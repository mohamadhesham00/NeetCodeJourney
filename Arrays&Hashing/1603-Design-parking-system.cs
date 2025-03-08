public class ParkingSystem {
    public int[] carTypes;
    public ParkingSystem(int big, int medium, int small) {
        carTypes = new int[] {0, big, medium, small};
    }
    
    public bool AddCar(int carType) {
        if (carTypes[carType]-- > 0)
            return true;
        return false;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */
