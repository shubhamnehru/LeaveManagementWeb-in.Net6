namespace LeaveManagement.web.Data
{
    public abstract class BaseEnitity  // why use abstract here because just for save side nobody can use / instantiated this class
                                      // without inherting this class 
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
