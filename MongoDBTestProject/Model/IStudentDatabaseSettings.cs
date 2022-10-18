namespace MongoDBTestProject.Model
{
    public interface IStudentDatabaseSettings
    {
        string StudentCollectionName { get; set; }
        string FuelStationCollectionName { get; set; }
        string FuelQueueHistoryCollectionName { get; set; }
        string FuelQueueCollectionName { get; set; }
        string FuelQueueRequestCollectionName { get; set; }

        string UserCollectionName { get; set; }
        string DatabaseName { get; set; } 
        string ConnectionString { get; set; }   


    }
}
