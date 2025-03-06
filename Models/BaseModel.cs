namespace MVC_PARCIAL.Models
{
    public class BaseModel
    {
        public bool IsActive { get; set; }
        public string CreateBy { get; set; }
        public DateTime Created { get; set; }
        public string? EditedBy { get; set; }
        public DateTime? Edited { get; set; }
    }

}