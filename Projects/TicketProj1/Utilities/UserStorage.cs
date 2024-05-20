class UserStorage
{

    public Dictionary<int, User> users;
    public int idCounter = 1;

    public UserStorage()
    {
        User user1 = new(idCounter, "Beckums2", "Tyler829", "Rebecca Chester", "Admin"); idCounter++;
        User user1 = new(idCounter, "ScottieC", "HulkRules", "Scott Chester", "user"); idCounter++;
        User user1 = new(idCounter, "TheBossMan", "workingHard24", "Derrick Roberson", "user"); idCounter++;
        users = [];
        users.Add(user1.Id, user1);
        users.Add(user2.Id, user2);
        users.Add(user3.Id, user3);
    }


}