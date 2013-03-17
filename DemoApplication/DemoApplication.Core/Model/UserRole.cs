namespace DemoApplication.Core.Model
{
    #region

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Newtonsoft.Json;

    #endregion

    public partial class UserRole : DomainObject
    {        
        [Required]
        public int UserId { get; set; }
        
        [ForeignKey("UserId")]
		[JsonIgnore]
        public virtual User User { get; set; }
        
        [Required]
        public int RoleId { get; set; }
        
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
    }
}